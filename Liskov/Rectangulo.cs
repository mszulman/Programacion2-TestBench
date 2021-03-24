using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Rectangulo
    {
        protected int _base;

        protected int _altura;

        //public int Base
        //{
        //    get { return _base; }
        //    set { _base = value; }
        //}

        //public int Altura
        //{
        //    get { return _altura; }
        //    set { _altura = value; }
        //}

        public int getBase()
        {
            return _base;
        }
        public void setBase(int bas)
        {
            this._base = bas;
        }
        public int getAltura()
        {
            return _altura;
        }
        public void setAltura(int altura)
        {
            this._altura = altura;
        }
        public Rectangulo()
        {
        }

        public int GetSuperficie()
        {
            return _base * _altura;
        }
    }
}
