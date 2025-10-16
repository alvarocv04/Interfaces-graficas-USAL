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

namespace Parabola_en_clase
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Polyline polilinea;      // Ya no declaramos aquí la polilínea y los ejes porque los hemos definido en XAML
        // Line ejex, ejey;

        double xrealmax, xrealmin, yrealmax, yrealmin;    // Ponemos estos campos en la clase porque los vamos a 

        public MainWindow()
        {
            InitializeComponent();

            ejex.RenderTransform = polilinea.RenderTransform;
            ejey.RenderTransform = polilinea.RenderTransform;

            xrealmax = 20;
            xrealmin = -15;
            yrealmax = 410;
            yrealmin = -10;
            panel.Width = xrealmax - xrealmin;
            panel.Height = yrealmax - yrealmin;
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            //   dibuja();
        }

        void dibuja()       // Solo trabajamos con coordenadas reales porque las coordenadas de pantalla las van a gestionar las transformaciones
        {
            int numpuntos = (int)panel.ActualWidth;  // nº de puntos de la polilínea
            double xreal, yreal;

            polilinea.Points.Clear();

            for (int i = 0; i < numpuntos; i++)
            {
                xreal = xrealmin + i * (xrealmax - xrealmin) / numpuntos;
                yreal = -xreal * xreal;                     // Multiplicamos la y por -1 para compensar el crecimiento inverso de las y en pantalla

                Point pt = new Point(xreal, yreal);
                polilinea.Points.Add(pt);
            }

            ejex.X1 = xrealmin;
            ejex.Y1 = 0;
            ejex.X2 = xrealmax;
            ejex.Y2 = 0;

            ejey.X1 = 0;
            ejey.Y1 = -yrealmin;
            ejey.X2 = 0;
            ejey.Y2 = -yrealmax;

        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Ya no tenemos que recalcular los puntos de la polilínea, solo tenemos que ajustar las propiedades de la transformación de traslación de la polilínea
            // Del escalado se encarga el ViewBox

            tt1.X = -xrealmin;
            tt1.Y = yrealmax;

            polilinea.StrokeThickness = 1 / Math.Max(miviewbox.ActualWidth / panel.Width, miviewbox.ActualHeight / panel.Height);
            ejex.StrokeThickness = panel.Height / miviewbox.ActualHeight;
            ejey.StrokeThickness = panel.Width / miviewbox.ActualWidth;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dibuja();
        }
    }
}