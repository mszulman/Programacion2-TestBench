using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.Edad = null;
            cliente.UltimoLogin = null;

            if (!cliente.UltimoLogin.HasValue)
            {
                // inicializar algo
            }
        }

        public class Cliente
        {
            public int? Edad { get; set; }
            public DateTime? UltimoLogin { get; set; }
        }

        public abstract class Fecha
        {
            public abstract bool TieneValor();
            public abstract string ConvertirAString();
        }
        public class FechaReal : Fecha
        {
            public override bool TieneValor()
            {
                return true;
            }
            public override string ConvertirAString()
            {
                return "ok";
            }
        }
        public class FechaNula : Fecha
        {
            public override bool TieneValor()
            {
                return false;
            }
            public override string ConvertirAString()
            {
                throw new Exception();
            }
        }
    }
}
