using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion4
{
    internal class Amigo
    {
        public string nombre {  get; set; }
        public string apellido { get; set; }
        public  int edad {  get; set; }

        public Amigo(String nombre, String apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        override public string ToString()
        {
            return nombre + " " + apellido + " Edad: " + edad;
        }

    }
}
