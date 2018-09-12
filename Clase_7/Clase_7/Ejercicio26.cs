using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    public class Ejercicio26
    {
        public static string Ex26()
        {
            int i, aux;
            const int CANT = 20, MIN = -500, MAX = 500;
            int[] Numeros = new int[CANT];

            Random r = new Random();

            StringBuilder sb = new StringBuilder();

            for (i = 0; i < CANT; i++)
            {
                do
                {
                    aux = r.Next(MIN, MAX);
                    Numeros[i] = aux;

                } while (aux == 0);
            }

            sb.AppendLine("TAL CUAL: ");
            sb.AppendLine("----------------------");
            for (i = 0; i < CANT; i++) // MUESTRO TAL CUAL LO CARGA
            {
                sb.AppendFormat("{0} ", Numeros[i]);
            }

            Array.Sort(Numeros); // ORDENO ASCENDENTEMENTE
            Array.Reverse(Numeros); // lo doy vuelta.

            sb.AppendLine("\n");
            sb.AppendLine("POSITIVOS DECRECIENTES");
            sb.AppendLine("----------------------");

            for (i = 0; i < CANT; i++)
            {
                if (Numeros[i] > 0)
                    sb.AppendFormat("{0} ", Numeros[i]);
            }

            Array.Reverse(Numeros); // vuelvo a dar vuelta, (menor a mayor)

            sb.AppendLine("\n");
            sb.AppendLine("NEGATIVOS CRECIENTES");
            sb.AppendLine("--------------------");
            for (i = 0; i < CANT; i++)
            {
                if (Numeros[i] < 0)
                    sb.AppendFormat("{0} ", Numeros[i]);
            }

            return sb.ToString();

        }

    }
}
