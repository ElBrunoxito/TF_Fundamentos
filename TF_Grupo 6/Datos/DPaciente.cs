using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPaciente
    {
        public List<Paciente> getAll()
        {
            List<Paciente> lista = new List<Paciente>();
            try
            {
                using (var contexto = new dbTFEntities())
                {
                    lista = contexto.Paciente.ToList();
                }
                 return lista;
            }
            catch
            {
                return lista;

            }
        }
        public string addPaciente(Paciente p)
        {
            try
            {
                using (var contexto = new dbTFEntities())
                {
                    contexto.Paciente.Add(p);
                    contexto.SaveChanges();
                }
                return $"{p.nombres} has sido registrado exitosamente";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }


        public bool Existe(Paciente p)
        {
            bool Ex = false;
            try
            {
                using (var contexto = new dbTFEntities())
                {
                    Ex = contexto.Paciente.Any(pa=>pa.DNI == p.DNI);
                }
                return Ex;
            }
            catch 
            {
                return Ex;
            }
        }

    }
}
