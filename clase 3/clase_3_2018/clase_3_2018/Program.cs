using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_3_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();

            alumno1.apellido = "Aguirre";
            alumno2.apellido = "Rodriguez";
            alumno3.apellido = "Toncic";

            alumno1.nombre = "Sebastian";
            alumno2.nombre = "Agustin";
            alumno3.nombre = "Luis";

            alumno1.legajo = 0001;
            alumno2.legajo = 0002;
            alumno3.legajo = 0003;

            alumno1.Estudiar(3, 6);
            alumno2.Estudiar(4, 2);
            alumno3.Estudiar(7, 9);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();

            //------------------------------------------//

            Boligrafo azul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo roja = new Boligrafo(50, ConsoleColor.Red);

            ConsoleColor original=Console.ForegroundColor;
            string dibujo="ERROR";

            Console.WriteLine("pinto primera vez: ");
            azul.Pintar(-10, out dibujo);
            Console.ForegroundColor = azul.GetColor();
            Console.WriteLine("azul: " +dibujo);
            roja.Pintar(-10, out dibujo);
            Console.ForegroundColor = roja.GetColor();
            Console.WriteLine("roja: " +dibujo);

            Console.ForegroundColor = original;

            Console.WriteLine("nivel de tinta azul: " + azul.GetTinta());
            Console.WriteLine("nivel de tinta roja: " + roja.GetTinta());

            Console.WriteLine("gasto de mas en cada uno: ");

            azul.Pintar(-110, out dibujo);
            Console.ForegroundColor = azul.GetColor();
            Console.WriteLine("azul: " + dibujo);
            roja.Pintar(-110, out dibujo);
            Console.ForegroundColor = roja.GetColor();
            Console.WriteLine("roja: " + dibujo);

            Console.ForegroundColor = original;

            Console.WriteLine("recargo: ");

            azul.Recargar();
            roja.Recargar();

            Console.WriteLine("nivel de tinta azul: " +azul.GetTinta());
            Console.WriteLine("nivel de tinta roja: " + roja.GetTinta());

            Console.WriteLine("gasto 40 en cada uno: ");

            azul.Pintar(-40, out dibujo);
            Console.ForegroundColor = azul.GetColor();
            Console.WriteLine("azul: " + dibujo);
            roja.Pintar(-40, out dibujo);
            Console.ForegroundColor = roja.GetColor();
            Console.WriteLine("roja: " + dibujo);

            Console.ForegroundColor = original;

            Console.WriteLine("nivel de tinta azul: " + azul.GetTinta());
            Console.WriteLine("nivel de tinta roja: " + roja.GetTinta());

            Console.WriteLine("gasto nuevamente 50 en cada uno: ");

            azul.Pintar(-50, out dibujo);
            Console.ForegroundColor = azul.GetColor();
            Console.WriteLine("azul: " + dibujo);
            roja.Pintar(-50, out dibujo);
            Console.ForegroundColor = roja.GetColor();
            Console.WriteLine("roja: " + dibujo);

            Console.ForegroundColor = original;

            Console.WriteLine("nivel de tinta azul: " + azul.GetTinta());
            Console.WriteLine("nivel de tinta roja: " + roja.GetTinta());

            Console.WriteLine("recargo 20 en cada uno: ");

            azul.Pintar(20, out dibujo);
            Console.ForegroundColor = azul.GetColor();
            Console.WriteLine("azul: " + dibujo);
            roja.Pintar(20, out dibujo);
            Console.ForegroundColor = roja.GetColor();
            Console.WriteLine("roja: " + dibujo);

            Console.ForegroundColor = original;

            Console.WriteLine("nivel de tinta azul: " + azul.GetTinta());
            Console.WriteLine("nivel de tinta roja: " + roja.GetTinta());

            Console.WriteLine("gasto 40 en cada uno (debe fallar): ");

            azul.Pintar(-40, out dibujo);
            Console.ForegroundColor = azul.GetColor();
            Console.WriteLine("azul: " + dibujo);
            roja.Pintar(-40, out dibujo);
            Console.ForegroundColor = roja.GetColor();
            Console.WriteLine("roja: " + dibujo);

           



            





            Console.ReadKey();


        }
    }
}
