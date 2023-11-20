using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPaciente
    {
        private DPaciente dPaciente = new DPaciente();
        public List<Paciente> getAll()
        {
            return dPaciente.getAll();  
        }
        public string addPaciente(Paciente p)
        {
            return dPaciente.addPaciente(p);
        }
        public bool Existe(Paciente p)
        {
            return dPaciente.Existe(p);
        }




    }
}
