using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FigurasBasicoJ2025
{
    public enum Figuras { rectangulo, elipse };
    public class Figura
    {
        public Figuras tipo { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public int deltax { get; set; }
        public int deltay { get; set; }
        public Shape fig { get; set; }
        public Color color { get; set; }

        public Figura()
        {
            Random rand = new Random();
            x = rand.Next(200);
            y = rand.Next(200);
            deltax = rand.Next(10);
            deltay = rand.Next(10);
            Color c = new Color();
            c.A = 255;
            c.B = (byte)rand.Next(255);
            c.G = (byte)rand.Next(255);
            c.R = (byte)rand.Next(255);
            color = c;
            tipo = (Figuras)rand.Next(2);
            if (tipo == Figuras.rectangulo) fig = new Rectangle();
            else fig = new Ellipse();
            fig.Fill = new SolidColorBrush(color);
            fig.Height = rand.Next(10, 20);
            fig.Width = rand.Next(10, 20);
        }

        public Figura(int maxx, int maxy)
        {
            Random rand = new Random();
            x = rand.Next(maxx);
            y = rand.Next(maxy);
            deltax = rand.Next(10);
            deltay = rand.Next(10);
            Color c = new Color();
            c.A = 255;
            c.B = (byte)rand.Next(255);
            c.G = (byte)rand.Next(255);
            c.R = (byte)rand.Next(255);
            color = c;
            tipo = (Figuras)rand.Next(2);
            if (tipo == Figuras.rectangulo) fig = new Rectangle();
            else fig = new Ellipse();
            fig.Fill = new SolidColorBrush(color);
            fig.Height = rand.Next(10, 20);
            fig.Width = rand.Next(10, 20);
        }


        public void mueve(double ancho, double alto)
        {
            if (deltax > 0)
                if (x + deltax + fig.Width < ancho) x += deltax;
                else
                {
                    x = ancho - fig.Width;
                    deltax *= -1;
                }
            else
                if (x + deltax > 0) x += deltax;
            else
            {
                x = 0;
                deltax *= -1;
            }

            if (deltay > 0)
                if (y + deltay + fig.Height < alto) y += deltay;
                else
                {
                    y = alto - fig.Height;
                    deltay *= -1;
                }
            else
                if (y + deltay > 0) y += deltay;
            else
            {
                y = 0;
                deltay *= -1;
            }

        }

    }
}
