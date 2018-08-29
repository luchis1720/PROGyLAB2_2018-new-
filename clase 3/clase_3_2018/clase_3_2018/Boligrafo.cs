using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_3_2018
{
    public class Boligrafo
    {
        #region FIELDS

        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        #endregion

        #region METHODS

        public Boligrafo()
        {

        }

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;

        }

        public ConsoleColor GetColor()
        {
            return this.color;

        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool ans = false;
            dibujo = "No alcanzo la Tinta";
    

            SetTinta((short)gasto);
            
            if(GetTinta()!=-1)
            {
                switch (gasto)
                {
                    case -10:
                        dibujo = "*";
                        ans = true;
                        break;
                    case -20:
                        dibujo = "**";
                        ans = true;
                        break;
                    case -30:
                        dibujo = "***";
                        ans = true;
                        break;
                    case -40:
                        dibujo = "****";
                        ans = true;
                        break;
                    case -50:
                        dibujo = "*****";
                        ans = true;
                        break;
                    case -60:
                        dibujo = "******";
                        ans = true;
                        break;
                    case -70:
                        dibujo = "*******";
                        ans = true;
                        break;
                    case -80:
                        dibujo = "********";
                        ans = true;
                        break;
                    case -90:
                        dibujo = "*********";
                        ans = true;
                        break;
                    case -100:
                        dibujo = "***********";
                        ans = true;
                        break;
                }
            }

            return ans;
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        private void SetTinta(short tinta)
        {
            int ans;

            ans = this.tinta + tinta;

            if (ans>=0 && ans<= cantidadTintaMaxima)
            {
                this.tinta = (short)ans;
            }
            else if(ans>= cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
            else
            {
                this.tinta = -1;
            }
        }
        
        #endregion

    }
}
