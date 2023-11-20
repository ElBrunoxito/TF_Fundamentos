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
    /// Lógica de interacción para ConsultasView.xaml
    /// </summary>
    public partial class ConsultasView : UserControl
    {
        private NComentario nComentario = new NComentario();
        private NRespuesta nRespuesta = new NRespuesta();
        private Comentario comentarioselec = null;
        private string DNIPaciente;
        public ConsultasView(string DNI)
        {
            InitializeComponent();
            MostrarComentarios(nComentario.ListarTodo());
            this.DNIPaciente = DNI;
        }
        private void MostrarRespuestas(List<Respuesta> respuestas)
        {
            cmbResponder.ItemsSource = new List<Respuesta>();
            cmbResponder.ItemsSource = respuestas;
            cmbResponder.DisplayMemberPath = "Descripcion";
            cmbResponder.SelectedValue = "Id_Respuesta";
        }
        private void MostrarComentarios(List<Comentario> comentarios)
        {
            cmbComentario.ItemsSource = new List<Comentario>();
            cmbComentario.ItemsSource = comentarios;
            cmbComentario.DisplayMemberPath = "descripcion";
            cmbComentario.SelectedValuePath = "idComentario";
        }

        private void btnComentar_Click_1(object sender, RoutedEventArgs e)
        {
            //validacion
            if (txtComentario.Text == "")
            {
                MessageBox.Show("Escriba un comentario");
                return;
            }
            //creacion del objeto
            Comentario comentario = new Comentario
            {
                descripcion = txtComentario.Text,
                Paciente_DNI = DNIPaciente
               
            };

            //agregar
            String mensaje = nComentario.Registrar(comentario);
            MessageBox.Show(mensaje);
            //mostrar comentario
            MostrarComentarios(nComentario.ListarTodo());
            cmbComentario.Text = comentario.descripcion;
            txtComentario.Text = "";

        }

        private void btnResponder_Click(object sender, RoutedEventArgs e)
        {
            // Validación de campos
            if (txtResponder.Text == "")
            {
                MessageBox.Show("Escriba una respuesta");
                return;
            }
            if (comentarioselec == null)
            {
                MessageBox.Show("Seleccione un comentario");
                return;
            }
            // Creación del objeto
            Respuesta respuesta = new Respuesta
            {
                Comentario_idComentario = comentarioselec.idComentario,
                Descripcion = txtResponder.Text
            };
            // Asignar el objeto
            String mensaje = nRespuesta.Asignar(respuesta);
            MessageBox.Show(mensaje);

            // Mostrar en el DataGrid
            MostrarRespuestas(nRespuesta.ListarTodo());
            cmbResponder.Text = respuesta.Descripcion;
            txtResponder.Text = "";
        }
        private void cmbComentario_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comentarioselec = cmbComentario.SelectedItem as Comentario;
        }



    }
}
