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
using System.Windows.Threading;

namespace FigurasBasicoJ2025
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        List<Figura> figuras;
        Figura figuraseleccionada = null;

        public MainWindow()
        {
            InitializeComponent();
            figuras = new List<Figura>();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 40);
            timer.Tick += Timer_Tick;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (Figura f in figuras)
            {
                f.mueve(lienzo.ActualWidth, lienzo.ActualHeight);
                Canvas.SetLeft(f.fig, f.x);
                Canvas.SetTop(f.fig, f.y);
            }
            tabla.Items.Refresh();

        }

        private void Button_Crear_Click(object sender, RoutedEventArgs e)
        {
            Figura nuevafigura = new Figura((int)lienzo.ActualWidth, (int)lienzo.ActualHeight);
            figuras.Add(nuevafigura);
            lienzo.Children.Add(nuevafigura.fig);
            tabla.Items.Add(nuevafigura);
            nuevafigura.fig.Tag = nuevafigura;
            Canvas.SetLeft(nuevafigura.fig, nuevafigura.x);
            Canvas.SetTop(nuevafigura.fig, nuevafigura.y);
            nuevafigura.fig.MouseDown += Fig_MouseDown;
        }

        private void Fig_MouseDown(object sender, MouseButtonEventArgs e)
        {

            figuras.Remove((Figura)((Shape)sender).Tag);
            lienzo.Children.Remove((Shape)sender);
            /*
                        foreach(Figura f in figuras)
                        {
                            if (f.fig==(Shape)sender)
                            {
                                figuras.Remove(f);
                                break;

                            }

                        }
            */

            tabla.Items.Remove((Figura)((Shape)sender).Tag);


        }

        private void Button_Animar_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            if (timer.IsEnabled)
            {
                timer.Stop();
                btn.Content = "Animar";
            }
            else
            {
                timer.Start();
                btn.Content = "Parar";
            }
        }


        private void Button_Borrar_Click(object sender, RoutedEventArgs e)
        {
            if (tabla.SelectedItem != null)
            {
                Figura faborrar = tabla.SelectedItem as Figura;
                figuras.Remove(faborrar);
                lienzo.Children.Remove(faborrar.fig);
                tabla.Items.Remove(faborrar);
            }
        }
    }
}
