using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.LiskovSubstitution.Correcto
{
    public class Main
    {
        // ...
        public static void main(string[] args)
        {
            Coche[] arrayCoches = {
        new Renault(),
        new Audi(),
        new Mercedes()
        };
            imprimirNumAsientos(arrayCoches);
            imprimirPrecioMedio(arrayCoches);
        }

        public static void imprimirNumAsientos(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                Console.WriteLine(coche.numAsientos());
            }
        }

        public static void imprimirPrecioMedio(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                Console.WriteLine(coche.precioMedioCoche());
            }
        }


    }
}

