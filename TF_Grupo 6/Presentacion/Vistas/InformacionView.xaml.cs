using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para InformacionView.xaml
    /// </summary>
    public partial class InformacionView : UserControl
    {
        List<Informacion_Adm> listaMovible = new List<Informacion_Adm>();
        private int pos = 0;

        private NInformacion nInformacion = new NInformacion();
        public InformacionView()
        {
            InitializeComponent();
            listaMovible = nInformacion.getAll();
            ColocarInformacion(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Buscar
            if (tb_busqueda.Text == "")
            {
                MessageBox.Show("Rellene el campo");
                return;
            }
            listaMovible = nInformacion.getPorstring(tb_busqueda.Text);
            if(listaMovible.Count == 0)
            {
                MessageBox.Show("No se encontro");
                return;
            }
            ColocarInformacion(0);



        }



        private void ColocarInformacion(int posicion)
        {

            if(listaMovible.Count != 0)
            {
                Titulo_Label.Content = listaMovible[posicion].nombre.ToString();
                Descripcion_Label.Content = listaMovible[posicion].descripcion.ToString();

            }


        }

        private void Derecha_tbn_Click(object sender, RoutedEventArgs e)
        {
            pos++;

            if (pos > listaMovible.Count - 1)
            {
                pos = 0;
            }

            ColocarInformacion(pos);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) 
        {
            //Izquierad
            //0
            pos--;

            if (pos < 0)
            {
                pos = listaMovible.Count - 1;
            }
            ColocarInformacion(pos);

        }


    }
}
