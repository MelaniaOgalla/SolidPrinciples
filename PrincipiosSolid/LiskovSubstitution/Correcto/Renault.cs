using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.LiskovSubstitution.Correcto
{
    public class Renault : Coche
    {
        public override int numAsientos()
        {
            return 3;
        }

        public override int precioMedioCoche()
        {
            return 150000;
        }
    }
}
