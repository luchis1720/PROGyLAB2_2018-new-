using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Clase_7
{
    class Ejercicio27
    {
        public static string Ex27Lista()
        {
            int aux;
            const int CANT = 20, MIN = -500, MAX = 500;

            List<int> Numeros;
            Numeros = new List<int>();

            Random r = new Random(DateTime.Now.Millisecond);
            StringBuilder sb = new StringBuilder();

            do
            {
                do
                {
                    aux = r.Next(MIN, MAX);
                } while (Object.ReferenceEquals(aux, 0));

                Numeros.Add(aux);

            } while (Numeros.Count < CANT);

            sb.AppendLine("\nNUMEROS CARGADOS: (LISTA)");
                        
            foreach (int item in Numeros)
            {
                sb.AppendFormat("\n{0}", item);
            }

            Numeros.Sort();

            sb.AppendLine("\n\n(NEGATIVOS) NUMEROS ORDENADOS menor a mayor: ");
            foreach (int item in Numeros)
            {
                if (item < 0)
                    sb.AppendFormat("\n{0}",item);
            }

            Numeros.Sort(Entidades.Libreria.OrdenarMayorAMenor);

            sb.AppendLine("\n\n(POSITIVOS) NUMEROS ORDENADOS mayor a menor: ");
            
            foreach (int item in Numeros)
            {
                if (item > 0)
                    sb.AppendFormat("\n{0}", item);
            }

            return sb.ToString();
        }

        public static string Ex27PilaCola()
        {
            StringBuilder sb = new StringBuilder();
            Random r = new Random();

            int aux;
            const int CANT = 20, MIN = -500, MAX = 500;

            List<int> Numeros = new List<int>();
            Stack<int> Positivos = new Stack<int>();  //LIFO
            Queue<int> Negativos = new Queue<int>();  //FIFO

            do
            {
                do
                {
                    aux = r.Next(MIN, MAX);
                } while (Object.ReferenceEquals(aux, 0));

                Numeros.Add(aux);

            } while (Numeros.Count < CANT);

            
            sb.AppendLine("\nNUMEROS CARGADOS: (USANDO PILAS Y COLAS)");

            foreach (int item in Numeros)
            {
                sb.AppendFormat("\n{0}", item);
            }

            Numeros.Sort(); // ordeno

            sb.AppendLine("\n\n(NEGATIVOS) NUMEROS ORDENADOS menor a mayor: ");
            foreach (int item in Numeros)
            {
                if (item < 0)
                {
                    Negativos.Enqueue(item);
                }
            }
            
            while(Negativos.Count>0)
            {
                sb.AppendFormat("\n{0}", Negativos.Dequeue());
            }

            foreach (int item in Negativos)
            {
                sb.AppendFormat("\n{0}", item); 
            }

            sb.AppendLine("\n\n(POSITIVOS) NUMEROS ORDENADOS mayor a menor: ");

            foreach (int item in Numeros)
            {
                if (item > 0)
                    Positivos.Push(item);
            }

            while(Positivos.Count>0)
            {
                sb.AppendFormat("\n{0}", Positivos.Pop());
            }

            foreach (int item in Positivos)
            {
                sb.AppendFormat("\n{0}", item); //sb.AppendFormat("\n{0}", Positivos.Pop())
            }

            return sb.ToString();
        }
    }
}
