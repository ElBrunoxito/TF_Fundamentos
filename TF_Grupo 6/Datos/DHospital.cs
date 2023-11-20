using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class DHospital
    {
        public List<Hospital> getAllPorMedico(int Medico)
        {
            List<Hospital> hospitals = new List<Hospital>();
            try
            {
                using (var context = new dbTFEntities())
                {
                    hospitals = context.Hospital
                        .Where(h=>h.HospitalMedico
                        .Any(hm=>hm.Medico_idMedico == Medico))
                        .ToList();
                }
                return hospitals;
            }
            catch
            {
                return hospitals;
            }
        }
        public List<Hospital> getAll()
        {
            List<Hospital> hospitals = new List<Hospital>();
            try
            {
                using (var context = new dbTFEntities())
                {
                    hospitals = context.Hospital.ToList();
                }
                return hospitals;
            }
            catch
            {
                return hospitals;
            }
        }



    }
}
