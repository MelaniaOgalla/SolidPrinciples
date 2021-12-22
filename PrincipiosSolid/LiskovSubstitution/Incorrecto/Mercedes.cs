using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.LiskovSubstitution.Incorrecto
{
    public class Mercedes : Coche
    {
        int numAsientosMercedes(Coche coche)
        {
            return 4;
        }
    }
}
