using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso
{
    public class Estante
    {
        #region Fields

        private Producto[] productos;
        private int ubicacionEstante;

        #endregion

        #region Methods

        private Estante (int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante (int capacidad, int ubicacion)
        : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            int i;
            StringBuilder sb = new StringBuilder();

            for (i = 0; i < e.productos.Length; i++)
            {
                sb.AppendLine(Producto.MostrarProducto(e.productos[i]));
            }

            return sb.ToString();
        }

        
        public static bool operator ==(Estante e, Producto p)
        {
            bool ans = false;
            int i;

            for (i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    ans = true;
                    break;
                }
            }

            return ans;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static Estante operator -(Estante e, Producto p)
        {
            int i;

            if (e == p)
            {
                for (i = 0; i < e.productos.Length; i++)
                {
                    if (Object.ReferenceEquals(e.productos[i], p))
                    {
                        e.productos[i] = null;
                    }
                }
            }

            return e;
    
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool ans = false;
            int i;
            if (e != p)
            {
                for (i = 0; i < e.productos.Length; i++)
                {
                    if (Object.ReferenceEquals(e.productos[i], null))
                    {
                        e.productos[i] = p;
                    ans = true;
                    break;
                    }

                }

            }

            return ans;

        }

        #endregion
    }
}
