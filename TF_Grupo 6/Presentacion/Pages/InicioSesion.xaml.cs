using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Presentacion.Pages
{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class InicioSesion : Window
    {
        private NPaciente nPaciente = new NPaciente();
        public InicioSesion()
        {
            InitializeComponent();
           
        }
     

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {            
            if(tbDNI.Text == "" || pbContraseña.Password == "")
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            if (tbDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe tener 8 digitos");
                return;
            }

            string DNI = tbDNI.Text;
            string Password = pbContraseña.Password;
            if (!nPaciente.Existe(new Paciente() { DNI =DNI, contasena = Password }))
            {
                //Registro
                MessageBox.Show("DNI no existente, tienes que registrarte ↓↓↓↓");
                return;
            }
            Paciente paciente = nPaciente.getAll().Find(p=>p.DNI == DNI);
            if(paciente.DNI != DNI || paciente.contasena != Password)
            {
                MessageBox.Show("DNI o contraseña incorrecta");
                return;
            }                         
            var w = new MainWindow(paciente);
            w.Show();
        }

        private void registrarse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Registro p = new Registro();
                p.Show();
            }
        }
    }
}
