using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.model
{
    class Tienda
    {
        private string modelo;
        private string tipo;
        private string marca;
        private int precio;
        public Tienda(string modelo,string tipo, string marca, int precio)
        {
            this.modelo = modelo;
            this.tipo = tipo;
            this.marca = marca;
            this.precio = precio;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Modelo { get => modelo; set => modelo = value; }
    }
}
