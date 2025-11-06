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

namespace Sesion5
{
    /// <summary>
    /// Lógica de interacción para Dialogo.xaml
    /// </summary>
    public partial class Dialogo : Window
    {
        public string cadena
        { 
            get { 
                return cajatexto.Text; 
            }
            set
            {
                cajatexto.Text = value;
            }
        }
        public Dialogo()
        {
            InitializeComponent();
            // Window mainWindow = Owner; No se debe utilizar para obtener una referencia a la ventana principal
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult= false;
        }
    }
}
