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

namespace Practica1
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

        private void BotonInvierte_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = CajaTexto;
            Label etiq = Etiqueta;
            int i;
            string aux = "";
            for (i = 0; i < tb.Text.Length; i++)
                aux += tb.Text[tb.Text.Length - i - 1];
            etiq.Content = aux;
        }

        private void BotonMayuscula_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = CajaTexto;
            Label etiq = Etiqueta;
            etiq.Content = tb.Text.ToUpper();
        }



        private void Color_Click(object sender, RoutedEventArgs e)
        {
            Window w = Ventana;
            if(sender==Rojo)
                w.Background = Brushes.Red;
            if(sender==Verde)
                w.Background = Brushes.Green;
        }

        

        private List<string> imagenes = new List<string>()
        {
            "C:\\Users\\alumno\\source\\repos\\Practica1\\Practica1\\Recursos\\imagen1.jpg",
            "C:\\Users\\alumno\\source\\repos\\Practica1\\Practica1\\Recursos\\imagen2.jpg",
            "C:\\Users\\alumno\\source\\repos\\Practica1\\Practica1\\Recursos\\imagen3.jpg",
            "C:\\Users\\alumno\\source\\repos\\Practica1\\Practica1\\Recursos\\imagen4.jpg",
            "C:\\Users\\alumno\\source\\repos\\Practica1\\Practica1\\Recursos\\imagen5.jpg",
            "C:\\Users\\alumno\\source\\repos\\Practica1\\Practica1\\Recursos\\imagen6.jpg",
            "C:\\Users\\alumno\\source\\repos\\Practica1\\Practica1\\Recursos\\imagen7.jpg",
            "C:\\Users\\alumno\\source\\repos\\Practica1\\Practica1\\Recursos\\imagen8.jpg",
            "C:\\Users\\alumno\\source\\repos\\Practica1\\Practica1\\Recursos\\imagen9.jpg"
        };
        
        private int indiceActual = 0;
        private void CambiarFondo_Click(object sender, RoutedEventArgs e)
        {
            // Incrementar el índice para avanzar en la lista
            indiceActual++;
            if (indiceActual >= imagenes.Count)
            {
                indiceActual = 0; // Volver al principio si llegamos al final
            }

            Uri imageUri = new Uri(imagenes[indiceActual], UriKind.Absolute);
            this.Background = new ImageBrush(new BitmapImage(imageUri));
        }
    }
}
