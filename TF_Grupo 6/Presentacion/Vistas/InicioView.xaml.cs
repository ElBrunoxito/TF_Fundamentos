using Entidades;
using Microsoft.Win32;
using Negocio;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica de interacción para InicioView.xaml
    /// </summary>
    public partial class InicioView : UserControl
    {
        private NServicios nServicios = new NServicios();
        private List<Servicios> listaMovible = new List<Servicios>();
        private int pos = 0;
        public InicioView()
        {
            InitializeComponent();
            //Agregar por una vez
            listaMovible = nServicios.getAll();
            ColocarServicio(0);
        }

        private void Izquierda_tbn_Click(object sender, RoutedEventArgs e)
        {
            //Izquierda
            pos--;

            if (pos < 0)
            {
                pos = listaMovible.Count - 1;
            }
            ColocarServicio(pos);
        }

        private void Derecha_tbn_Click(object sender, RoutedEventArgs e)
        {
            //Derecha
            pos++;

            if (pos > listaMovible.Count - 1)
            {
                pos = 0;
            }

            ColocarServicio(pos);
        }


        private void ColocarServicio(int posicion)
        {

            if (listaMovible.Count != 0)
            {
                byte[] arrayDeBytes = listaMovible[pos].imagen;

                // Crear un objeto BitmapImage
                BitmapImage imagen = new BitmapImage();
                using (MemoryStream memoryStream = new MemoryStream(arrayDeBytes))
                {
                    imagen.BeginInit();
                    imagen.CacheOption = BitmapCacheOption.OnLoad;
                    imagen.StreamSource = memoryStream;
                    imagen.EndInit();
                }
                

                label_titulo.Content = listaMovible[posicion].nombre.ToString();
                label_descripcion.Content = listaMovible[posicion].descripcion.ToString();
                Imagen.Source = imagen;

            }


        }



    }
}
