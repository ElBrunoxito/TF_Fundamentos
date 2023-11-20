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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentacion.Vistas
{
    /// <summary>
    /// Lógica de interacción para ProgramarCitaView.xaml
    /// </summary>
    public partial class ProgramarCitaView : UserControl
    {
        private Paciente this_paciente = new Paciente();

        private NCitas nCitas = new NCitas();   



        private NEspecialidad nEspecialidad = new NEspecialidad();
        private NMedico nMedico = new NMedico();
        private NHospital nHospital = new NHospital();

        private bool datePicterabietto = false;
        public ProgramarCitaView(Paciente p)
        {
            InitializeComponent();
            this_paciente = p;
            AddcomboBoxEspecialidad();
        }

        private void btReversar_Click(object sender, RoutedEventArgs e)
        {
            if (cbEspecialidad.Items.Count == 0 || cbMedico.Items.Count == 0 || cbHospital.Items.Count == 0)
            {
                MessageBox.Show("No hay reserva D:");
                return;
            }
            if (cbEspecialidad.Text == "" || cbMedico.Text == "" || cbHospital.Text == "" || !datePicterabietto)
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            DateTime dtTemp = DateTime.Now;
            if (dtTemp.Month > DFecha.SelectedDate.Value.Month || dtTemp.Day > DFecha.SelectedDate.Value.Day)
            {
                MessageBox.Show("Elija un horario o dia correcto :)");
                return;
            }
            TimeSpan xd = new TimeSpan(1,0,0);
            
            Citas_Medicas citatemp = new Citas_Medicas()
            {
                fecha = DFecha.SelectedDate.Value.Date,
                estadoDeLaCita = "Programada",
                duracion = TimeSpan.FromHours(1),
                Consulta_EnLinea = true,
                Paciente_DNI = this_paciente.DNI,
                HospitalMedico_Medico_idMedico = (int)cbMedico.SelectedValue,
                HospitalMedico_Hospital_idHospital = (int)cbHospital.SelectedValue
            };

            string ms = nCitas.AddCita(citatemp);
            MessageBox.Show(ms);



        }

        private void cbEspecialidad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddComboBoxMedicoPorEspecialidad((int)cbEspecialidad.SelectedValue);
        }
        private void cbMedico_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddHospitalesxMedico((int)cbMedico.SelectedValue);

        }



        private void AddcomboBoxEspecialidad()
        {
            cbEspecialidad.ItemsSource = new List<Especialidad>();
            cbEspecialidad.ItemsSource = nEspecialidad.getAll();
            cbEspecialidad.DisplayMemberPath = "nombre";
            cbEspecialidad.SelectedValuePath = "idEspecialidad";
        }
        private void AddHospitalesxMedico(int id)
        {
            cbHospital.ItemsSource = new List<Especialidad>();
            cbHospital.ItemsSource = nHospital.getAllPorMedico(id);
            cbHospital.DisplayMemberPath = "nombre";
            cbHospital.SelectedValuePath = "idHospital";

        }

        private void AddComboBoxMedicoPorEspecialidad(int id)
        {            
            cbMedico.ItemsSource = new List<Medico>();
            cbMedico.ItemsSource = nMedico.getPorEspecialidad(id);
            cbMedico.DisplayMemberPath = "nombreCompleto";
            cbMedico.SelectedValuePath = "idMedico";
        }

        private void DFecha_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((DatePicker)sender).SelectedDate.HasValue)
            {
                datePicterabietto = true;

            }
            else
            {
                datePicterabietto = false;
            }
        }
    }
}
