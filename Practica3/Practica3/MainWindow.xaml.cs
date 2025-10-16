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
        Line ejeX;
        Line ejeY;
        public MainWindow()
        {   
            
            InitializeComponent();
            polilinea = new Polyline();
            polilinea.Stroke = Brushes.Red;
            lienzo.Children.Add(polilinea);
            
            ejeX = new Line();
            ejeX.Stroke = Brushes.Black;
            lienzo.Children.Add(ejeX);
            
            ejeY = new Line();
            ejeY.Stroke = Brushes.Black;
            lienzo.Children.Add(ejeY);
        }

        void dibuja()
        {
            double xreal, yreal, xrealmax = 10, xrealmin = -5, yrealmin = -10, yrealmax = 110;
            double xpant, ypant, xpantmax, xpantmin, ypantmax, ypantmin;
            xpantmin = lienzo.ActualWidth / 2;
            ypantmin = 0;
            xpantmax = lienzo.ActualWidth;
            ypantmax = lienzo.ActualHeight / 2;
            int numpuntos = (int)lienzo.ActualWidth;


            polilinea.Points.Clear();
            for (int i = 0; i < numpuntos; i++)
            {
                xreal = xrealmin + i * (xrealmax - xrealmin) / numpuntos;
                yreal = xreal * xreal;

                xpant = (xpantmax - xpantmin) * (xreal - xrealmin) / (xrealmax - xrealmin) + xpantmin;
                ypant = (ypantmin - ypantmax) * (yreal - yrealmin) / (yrealmax - yrealmin) + ypantmax;
                Point pt = new Point(xpant, ypant);
                polilinea.Points.Add(pt);
            }
            ejeX.X1 = xpantmin;
            ejeX.X2 = xpantmax;
            ejeX.Y1 = (ypantmin - ypantmax) * (0 - yrealmin) / (yrealmax - yrealmin) + ypantmax;
            ejeX.Y2 = ejeX.Y1;

            ejeY.Y1 = ypantmin;
            ejeY.Y2 = ypantmax;
            ejeY.X1 = (xpantmax - xpantmin) * (0 - xrealmin) / (xrealmax - xrealmin) + xpantmin;
            ejeY.X2 = ejeY.X1;

        }

        private void Boton_Click(object sender, RoutedEventArgs e)
        {

            dibuja();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            dibuja();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dibuja();
        }
    }
}
