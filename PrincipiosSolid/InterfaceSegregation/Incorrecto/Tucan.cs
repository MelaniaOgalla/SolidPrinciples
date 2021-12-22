using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.InterfaceSegregation.Incorrecto
{
    public class Tucan : IAve
    {
        public void comer()
        {
            throw new NotImplementedException();
        }

        public void nadar()
        {
            throw new NotImplementedException();
        }

        public void volar()
        {
            throw new NotImplementedException();
        }
    }
}
