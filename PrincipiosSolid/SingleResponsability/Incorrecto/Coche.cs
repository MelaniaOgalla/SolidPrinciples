using System;

namespace PrincipiosSolid
{
    public class Coches
    {
        String Marca;

        Coches(string marca)
        {
            this.Marca = marca;
        }

        string getMarcaCoche()
        {
            return Marca;
        }

        void guardarCocheDB(Coche coche)
        {

        }
    }
}
