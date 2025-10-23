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

namespace Practica3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Polyline polilinea;

        public MainWindow()
        {   
            
            InitializeComponent();
            polilinea = new Polyline();
            polilinea.Stroke = Brushes.Red;
            lienzo.Children.Add(polilinea);
            
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point punto = e.GetPosition(lienzo);

            polilinea.Points.Add(punto);
        }
    }
}
