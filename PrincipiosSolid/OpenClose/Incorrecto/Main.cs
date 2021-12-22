using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClose.Incorrecto
{
    public class Main
    {
        public static void main(string[] args)
        {
            Coche[] arrayCoches = {
            new Coche("Renault"),
            new Coche("Audi")
            };
            imprimirPrecioMedioCoche(arrayCoches);
        }

        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                if (coche.marca.Equals("Renault")) Console.WriteLine(18000);
                if (coche.marca.Equals("Audi")) Console.WriteLine(25000);
            }
        }
    }
}
