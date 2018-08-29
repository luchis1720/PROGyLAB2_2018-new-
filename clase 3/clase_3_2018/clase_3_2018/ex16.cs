using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_3_2018
{
    public class Alumno
    {
        #region FIELDS
        private byte nota1;
        private byte nota2;
        private float notaFinal = -1;
        public string apellido;
        public int legajo;
        public string nombre;
        #endregion
        #region METHODS

        public Alumno()
        {

        }

        public void CalcularFinal()
        {
            Random rnd = new Random();

            if(nota1>=4 && nota2>=4)
            {
                this.notaFinal = rnd.Next(4, 10);
            }
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public string Mostrar()
        {
            string ans = "";
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");
            sb.AppendFormat("Legajo: {0} - ",legajo);
            sb.Append("Alumno: "+ nombre + " " + apellido);
            sb.AppendLine("");

            if (notaFinal != -1)
            {
                sb.AppendFormat("1er nota: {0}", nota1);
                sb.AppendLine(" ");
                sb.AppendFormat("2da nota: {0}", nota2);
                sb.AppendLine(" ");
                sb.AppendFormat("Nota Final: {0}", notaFinal);
            }
            else
            {
                sb.AppendLine("Alumno Desaprobado");
            }

            sb.AppendLine("");
            sb.AppendLine("-------------");

            ans = sb.ToString();
            return ans;
        }

    }

    #endregion

}

