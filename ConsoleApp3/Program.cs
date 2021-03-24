using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public delegate void Hablar(Mascota mascota, string texto);

    partial class Program
    {
        static void Main(string[] args)
        {
            var perrito = new Perro("Albert");
            var gatito = new Gato("Maurice");

            perrito.Hablo += CapturarLoQueMeDicen;
            perrito.Hablo += RepetirLoQueMeDicen;

            gatito.Hablo += CapturarLoQueMeDicen;
            gatito.Hablo += RepetirLoQueMeDicen;

            perrito.DecirAlgo();
            gatito.DecirAlgo();

            Console.ReadLine();
        }

        public static void CapturarLoQueMeDicen(Mascota mascota, string texto)
        {
            Console.WriteLine(mascota.Nombre + " dijo \"" + texto + "\"\n");
        }

        public static void RepetirLoQueMeDicen(Mascota mascota, string texto)
        {
            Console.WriteLine(texto + " (" + mascota.Nombre + " dixit)\n");
        }
    }
}