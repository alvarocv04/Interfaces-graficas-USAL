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

namespace FigurasBasicoJ2025
{
    /// <summary>
    /// Lógica de interacción para Dialogo.xaml
    /// </summary>
    public partial class Dialogo : Window
    {
        public Dialogo()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tabla_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (figuraseleccionada != null)
            {
                figuraseleccionada.fig.Stroke = null;
            }
            if (tabla.SelectedItem != null)
            {
                figuraseleccionada = (Figura)tabla.SelectedItem;
                figuraseleccionada.fig.Stroke = Brushes.Red;
                figuraseleccionada.fig.StrokeThickness = 3;
                botonborrar.IsEnabled = true;
            }
            else
            {
                botonborrar.IsEnabled = false;
            }

        }
    }
}
