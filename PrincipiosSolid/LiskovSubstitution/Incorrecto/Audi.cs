using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.LiskovSubstitution.Incorrecto
{
    public class Audi : Coche
    {
        int numAsientosAudi(Coche coche)
        {
            return 3;
        }
    }
}
