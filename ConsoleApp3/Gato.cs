using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Gato : Mascota
    {
        public Gato(string nombre) : base(nombre)
        {
        }

        public override void DecirAlgo()
        {
            DijeAlgo("Si Se Puede!");
        }
    }
}
