using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Perro : Mascota
    {
        public Perro(string nombre) : base(nombre)
        {
        }

        public override void DecirAlgo()
        {
            DijeAlgo("2 semanas más de cuarentena");
        }
    }
}
