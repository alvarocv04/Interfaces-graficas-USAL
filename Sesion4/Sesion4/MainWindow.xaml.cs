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

namespace Sesion4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Amigo> misamigos;
        public MainWindow()
        {
            InitializeComponent();
            misamigos= new List<Amigo>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Amigo amigo = new Amigo(caja1.Text, caja2.Text, 20); //La edad me la invento
            misamigos.Add(amigo);
            tabla.Items.Add(amigo);
        }

        private void tabla_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //No debo hacer nada con el elemento seleccionado sin previamente comprobar que es distinto de null
            if(tabla.SelectedItem != null)
            {
                Amigo amigo = (Amigo)tabla.SelectedItem;
                amigo.edad += 2;
                etiq.Content = amigo;
                tabla.Items.Refresh();
            }
            /*if (tabla.SelectedIndex != -1)
            {
                string s = (String)tabla.Items[tabla.SelectedIndex];
                etiq.Content = s
            }*/
            
        }
    }
}
