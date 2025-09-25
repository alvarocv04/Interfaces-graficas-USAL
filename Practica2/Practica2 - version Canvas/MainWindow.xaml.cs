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

namespace Practica2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mipanel.Focus();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            double aux;
            switch (e.Key)
            {
                case Key.Down:
                    aux = Canvas.GetTop(rect);
                    // if(aux < mipanel.RowDefinitions.Count-1 ) Grid.SetRow(rect, aux + 1);
                    break;
                case Key.Up:
                    aux = Grid.GetRow(rect);
                    if (aux > 0) Grid.SetRow(rect, aux - 1);
                    break;
                case Key.Right:
                    aux = Grid.GetColumn(rect);
                    if (aux < mipanel.ColumnDefinitions.Count - 1) Grid.SetColumn(rect, aux + 1);
                    break;
                case Key.Left:
                    aux = Grid.GetColumn(rect);
                    if (aux > 0) Grid.SetColumn(rect, aux - 1);
                    break;
                case Key.Add:
                case Key.OemPlus:
                    miescalado.ScaleX *= 1.1;
                    miescalado.ScaleY *= 1.1;
                    break;
                case Key.OemMinus:
                case Key.Subtract:
                    miescalado.ScaleX *= 0.9;
                    miescalado.ScaleY *= 0.9;
                    break;
            }
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            mirotacion.Angle += 10; 
        }
    }
}
