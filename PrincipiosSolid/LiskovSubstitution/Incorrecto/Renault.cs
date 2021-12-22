using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.LiskovSubstitution.Incorrecto
{
    public class Renault : Coche
    {
        int numAsientosRenault(Coche coche)
        {
            return 5;
        }
    }
}
