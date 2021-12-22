using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.InterfaceSegregation.Correcto
{
    interface IAve
    {
        void comer();
    }
    interface IAveVoladora
    {
        void volar();
    }

    interface IAveNadadora
    {
        void nadar();
    }
}
