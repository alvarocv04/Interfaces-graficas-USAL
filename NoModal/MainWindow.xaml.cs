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

namespace Sesion5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dialogo dialogo = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (dialogo == null)
            {
                dialogo= new Dialogo();
                dialogo.Owner = this; //Es para no poder poner por delante la otra ventana
                dialogo.HayNuevaCadena += Dialogo_HayNuevaCadena;
                dialogo.Closed += Dialogo_Closed;
            }
            dialogo.cadena = Title;
            dialogo.Show(); //Modo no modal
            
            
        }

        private void Dialogo_Closed(object sender, EventArgs e)
        {
            dialogo = null;
        }

        private void Dialogo_HayNuevaCadena(object sender, CadenaEventArgs e)
        {
            Title = e.Cadena;
        }
    }
}
