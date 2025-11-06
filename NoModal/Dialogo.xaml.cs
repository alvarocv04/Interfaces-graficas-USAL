using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public class CadenaEventArgs : EventArgs
    {
        public string Cadena { get; set; }
        public CadenaEventArgs(string s) 
        { Cadena = s; }
    }
    
    public partial class Dialogo : Window
    {
        public event EventHandler<CadenaEventArgs> HayNuevaCadena;  //NO USAR ACTION
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
        void OnHayNuevaCadena(string s)
        {
            if (HayNuevaCadena != null) {
                HayNuevaCadena(this, new CadenaEventArgs(s));
            }
        }
        public Dialogo()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cajatexto_TextChanged(object sender, TextChangedEventArgs e)
        {
            OnHayNuevaCadena(cadena);
        }
    }
}
