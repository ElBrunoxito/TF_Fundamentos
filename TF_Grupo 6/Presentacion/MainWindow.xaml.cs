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
using System.Windows.Threading;
using Entidades;
using Presentacion.Vistas;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        double panelWidth;
        bool hidden;
        private Paciente usuario;
        public MainWindow(Paciente p)
        {
            InitializeComponent();
            usuario = p;
            TB_Usuario.Text = p.nombres;

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Tick += Timer_Tick;

            panelWidth = sidePanel.Width;
            contentControl.Content = new MainView();
            

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                sidePanel.Width += 1;
                if (sidePanel.Width >= panelWidth)
                {
                    timer.Stop();
                    hidden = false;
                }
            }
            else
            {
                sidePanel.Width -= 1;
                if (sidePanel.Width <= 35)
                {
                    timer.Stop();
                    hidden = true;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            /*InicioWindow window = new InicioWindow();
            window.Show();*/

           
            contentControl.Content = new InicioView()
            {
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
            };
        }

        private void StackPanel_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            //Programar Cita
            contentControl.Content = new ProgramarCitaView(usuario)
            {
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
            };
        }

        private void StackPanel_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            //Informacion
            contentControl.Content = new InformacionView()
            {
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
            };
        }

        private void StackPanel_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            //Educacion
            contentControl.Content = new EducacionView(){ 
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center, VerticalAlignment = System.Windows.VerticalAlignment.Center 
            };



        }

        private void StackPanel_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            //Consultas
            contentControl.Content = new ConsultasView(usuario.DNI)
            {
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Center
            };
        }

        private void StackPanel_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            //Usuario
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
