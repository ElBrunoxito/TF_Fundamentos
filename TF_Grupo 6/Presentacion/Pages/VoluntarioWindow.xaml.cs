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
    /// Lógica de interacción para VoluntarioWindow.xaml
    /// </summary>
    public partial class VoluntarioWindow : Window
    {
        private NVoluntario nVoluntariado = new NVoluntario();
        private NHospital nHospital = new NHospital();

        private Volunraio voluntariadoseleccionado = null;
        private List<Hospital> hospitales = new List<Hospital>();
        public VoluntarioWindow()
        {
            InitializeComponent();
            MostrarVoluntariados(nVoluntariado.ListarTodo());

            hospitales = nHospital.getAll();
            MessageBox.Show(hospitales.Count.ToString());

            MostrarHospitales(hospitales);
        }



        private void MostrarHospitales(List<Hospital> hospital)
        {
            cmbHospital.ItemsSource = new List<Hospital>();            
            cmbHospital.ItemsSource = hospital;
            cmbHospital.DisplayMemberPath = "nombre";
            cmbHospital.SelectedValuePath = "idHospital";

        }
        private void MostrarVoluntariados(List<Volunraio> voluntariados)
        {
            datagridVoluntariado.ItemsSource = new List<Volunraio>();
            datagridVoluntariado.ItemsSource = voluntariados;
        }
        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {

            // Validación de campos
            if (txtHorario.Text == "" || txtNombre.Text == "" || cmbHospital.Text == "" || txtTipo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Volunraio voluntariado = new Volunraio
            {
                Nombre = txtNombre.Text,
                Hospital_idHospital = (int) cmbHospital.SelectedValue,///Cambiar para id de hospital
                Tipo = txtTipo.Text,
                Horario = DateTime.Parse(txtHorario.Text)
            };

            // Registrar el objeto
            String mensaje = nVoluntariado.Registrar(voluntariado);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarVoluntariados(nVoluntariado.ListarTodo());

        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {

            // Validación de campos
            if (txtHorario.Text == "" || txtNombre.Text == "" || cmbHospital.Text == "" || txtTipo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de selección
            if (voluntariadoseleccionado == null)
            {
                MessageBox.Show("Seleccione un voluntariado");
                return;
            }
            // Creación del objeto
            Volunraio voluntariado = new Volunraio
            {
                idVoluntario = voluntariadoseleccionado.idVoluntario,
                Nombre = txtNombre.Text,
                Hospital_idHospital = (int)cmbHospital.SelectedValue, // Cabmia para id de Hospital
                Tipo = txtTipo.Text,
                Horario = DateTime.Parse(txtHorario.Text)
            };
            // Registrar el objeto
            String mensaje = nVoluntariado.Modificar(voluntariado);
            MessageBox.Show(mensaje);

            MostrarVoluntariados(nVoluntariado.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Validación de selección
            if (voluntariadoseleccionado == null)
            {
                MessageBox.Show("Seleccione un voluntariado");
                return;
            }

            // Eliminar
            String mensaje = nVoluntariado.Eliminar(voluntariadoseleccionado.idVoluntario);
            MessageBox.Show(mensaje);

            MostrarVoluntariados(nVoluntariado.ListarTodo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void datagridVoluntariado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            voluntariadoseleccionado = datagridVoluntariado.SelectedItem as Volunraio;
        }









    }
}
