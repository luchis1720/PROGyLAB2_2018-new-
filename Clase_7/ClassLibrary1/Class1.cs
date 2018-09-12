using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libreria
    {
        public static int OrdenarMayorAMenor(int a, int b)
        {
            return -(a.CompareTo(b));
        }
    }
}
