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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Dialogo dialogo = new Dialogo();
            dialogo.cadena = Title;
            dialogo.Owner =this; //Es para no poder poner por delante la otra ventana
            dialogo.ShowDialog(); //Modo modal
            if (dialogo.DialogResult == true)
            {
                //Title = dialogo.cajatexto.Text; //NOOOO NO HACER ASÍ NUNCA DESDE UN METODO AJENO A LA VENTANA SE ACCEDE A LA VENTANA
                Title = dialogo.cadena;
            }
        }
    }
}
