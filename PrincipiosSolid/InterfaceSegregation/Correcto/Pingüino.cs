using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.InterfaceSegregation.Correcto
{
    public class Pingüino : IAve, IAveNadadora
    {
        public void comer()
        {
            throw new NotImplementedException();
        }

        public void nadar()
        {
            throw new NotImplementedException();
        }
    }
}
