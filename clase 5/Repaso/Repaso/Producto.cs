﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso
{
    public class Producto
    {
        #region Fields

        private string codigoDeBarra;
        private string marca;
        private float precio;

        #endregion

        #region Methods

        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public static explicit operator string(Producto p)
        {
            string ans = "";

            ans = p.codigoDeBarra;

            return ans;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            if (!Object.ReferenceEquals(p, null))
            {
                sb.AppendLine("PRODUCTO:");
                sb.AppendFormat("Marca: {0} ", p.marca);
                sb.AppendFormat("Codigo de Barra: {0} ", p.codigoDeBarra);
                sb.AppendFormat("Precio: {0}", p.precio);
                sb.AppendLine("");
            }

            return sb.ToString();
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool ans = false;
            if (p.marca == marca)
                ans = true;
            return ans;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool ans = false;
            if (!(object.ReferenceEquals(p1, null)) && !(object.ReferenceEquals(p2, null)))
            {
                if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                    ans = true;
            }

            return ans;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        #endregion
    }
}
