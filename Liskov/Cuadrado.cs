using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Cuadrado : Rectangulo
    {
        public int Base
        {
            get { return _base; }
            set
            {
                _base = value;
                _altura = _base;
            }
        }

        public int Altura
        {
            get { return _altura; }
            set
            {
                _altura = value;
                _base = _altura;
            }
        }
    }
}
