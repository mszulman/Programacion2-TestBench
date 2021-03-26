using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Cuadrado : Rectangulo
    {
        public new void setBase(int bas)
        {
            this._base = bas;
            this._altura = this._base;
        }
        public new void setAltura(int altura)
        {
            this._altura = altura;
            this._base = this._altura;
        }
    }
}
