using Negocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace Presentacion.Pages
{
    /// <summary>
    /// Lógica de interacción para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        private NPaciente nPaciente = new NPaciente();
        private bool datePicterabietto = false;
        public Registro()
        {
            InitializeComponent();
            cbGenero.Items.Add("Masculino");
            cbGenero.Items.Add("Femenino");
        }

        private void btnListo_Click(object sender, RoutedEventArgs e)
        {
            if(tbNombres.Text == "" || tbApellidos.Text == "" || tbDni.Text == ""  || cbGenero.Text == "" || tbDireccion.Text == "" || tbCorreoElectronico.Text == "" ||tbTelefono.Text == "" || pbContraseña.Password == "" || pbConfirmarContraseña.Password == "" || !datePicterabietto)
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            if (!EsCorreo(tbCorreoElectronico.Text))
            {
                MessageBox.Show("Ingrese un correo existente");
                return;
            }

            if(nPaciente.Existe(new Paciente() { DNI = tbDni.Text }))
            {
                MessageBox.Show("Este DNI ya se registro");
                return;
            }
            if (pbContraseña.Password != pbConfirmarContraseña.Password)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }
            if (!ValidarContraseña(pbContraseña.Password))
            {
                MessageBox.Show("La contraseña debe tener 8 caracteres y un numero como minimo");
                return;
            }

            Paciente ptemt = new Paciente()
            {
                DNI = tbDni.Text,
                nombres = tbNombres.Text,
                apellidos = tbApellidos.Text,
                fechaNacimiento = dfechaN.SelectedDate.Value,
                genero = cbGenero.Text == "Masculino" ? "M" : "F",
                direccion = tbDireccion.Text,
                telefono = tbTelefono.Text,
                correoElectronico = tbCorreoElectronico.Text,
                avatar = ConvertBitmapImageToByteArray(),
                contasena = pbContraseña.Password
            };
            string ms = nPaciente.addPaciente(ptemt);
            MessageBox.Show(ms);
            this.Close();

        }


        private bool EsCorreo(string correo)
        {
            string patronCorreo = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Se utiliza la clase Regex para realizar la validación
            Regex regex = new Regex(patronCorreo);

            return regex.IsMatch(correo);
        }
        private bool ValidarContraseña(string contraseña)
        {
            // La expresión regular requiere al menos 8 caracteres y al menos un número
            string patron = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";

            Regex regex = new Regex(patron);

            return regex.IsMatch(contraseña);
        }
        public byte[] ConvertBitmapImageToByteArray()
        {
            BitmapImage bitmapImage = new BitmapImage(new Uri("C:\\Yo\\Cursos\\Fundamentos\\Trabajo Final\\TF_Grupo 6\\Presentacion\\Images\\usuario.png"));

            byte[] result = null;

            if (bitmapImage != null)
            {
                BitmapEncoder encoder = new PngBitmapEncoder(); // Puedes elegir el codificador que mejor se adapte a tus necesidades
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    encoder.Save(memoryStream);
                    result = memoryStream.ToArray();
                }
            }

            return result;
        }

        private void label_btn_ingresar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                this.Close();
            }
        }

        private void dfechaN_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
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
