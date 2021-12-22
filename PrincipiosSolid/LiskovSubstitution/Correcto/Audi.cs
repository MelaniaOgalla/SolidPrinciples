using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.LiskovSubstitution.Correcto
{
    public class Audi : Coche
    {
    
    public override int numAsientos()
        {
            return 5;
        }

        public override int precioMedioCoche()
        {
            return 200000;
        }
    }
}
