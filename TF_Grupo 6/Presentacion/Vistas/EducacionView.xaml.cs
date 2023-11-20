using Presentacion.Pages;
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
    /// Lógica de interacción para EducacionView.xaml
    /// </summary>
    public partial class EducacionView : UserControl
    {
        public EducacionView()
        {
            InitializeComponent();
        }

        private void btnRegistrarVoluntariado_Click(object sender, RoutedEventArgs e)
        {
            VoluntarioWindow window = new VoluntarioWindow();
            window.Show();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
