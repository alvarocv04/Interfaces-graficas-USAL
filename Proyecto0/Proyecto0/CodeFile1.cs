using System;
using System.Windows;
using System.Windows.Controls;
namespace Proyectos.ElSegundo
{
    class Basica
    {
        [STAThread]
        public static void Main()
        {
            Window win = new Window();
            win.Title = "Segundo Programa";
            win.Show();
            Console.WriteLine("Ventana abierta");

            Label etiqueta = new Label();
            etiqueta.Content = "Hola Mundo";
            win.Content = etiqueta;
            Application app = new Application();
            Console.WriteLine("Entrando en el bucle de mensajes");
            app.Run();
            Console.WriteLine("Acabamdo bucle");
        }
    }
}