using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.LiskovSubstitution.Incorrecto
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
        }   

        public static void imprimirNumAsientos(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {
                if (coche.GetType() == typeof(Renault))

                    Console.WriteLine("Num asientos 4");

                if (coche.GetType() == typeof(Audi))

                    Console.WriteLine("Num asientos 5");

                if (coche.GetType() == typeof(Mercedes))

                    Console.WriteLine("Num asientos 4");

            }
        }
}
}
