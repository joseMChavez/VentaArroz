using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Factorizacion 
    {
        public int FactId { get; set; }
        public int Cantidad { get; set; }
        public string Peso { get; set; }
        public float Precio { get; set; }

        public Factorizacion() {
            FactId = 0;
            Cantidad = 0;
            Peso = "";
            Precio = 0;
        }

        public Factorizacion(int cantidad, string peso, float precio)
        {
            Cantidad = cantidad;
            Peso = peso;
            Precio = precio;
        }

    }
}
