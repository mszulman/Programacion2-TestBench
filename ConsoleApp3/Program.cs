using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public delegate void Hablar(string texto);

        static void Main(string[] args)
        {
            var perrito = new Mascota();
            perrito.Hablo += Sarasa;

            perrito.Ladrar();

            Console.ReadLine();
        }

        public static void Sarasa(string texto)
        {
            Console.WriteLine(texto);
        }

        public class Mascota
        {
            public Mascota()
            {
            }

            public event Hablar Hablo;

            public void Ladrar()
            {
                Hablo("Guau Guau");
            }
        }
    }
}