using System;
using ConsoleApp7.model;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("┌────────────────────────────────────────────┐");
            Console.WriteLine("│             TIENDA DE ARTICULOS            │");
            Console.WriteLine("└────────────────────────────────────────────┘");
            Console.WriteLine("¿Cuantos Articulos Agregara?");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Tienda[] listaProductos = new Tienda[opcion];
            for (int i = 0; i < opcion; i++)
            {
                Console.WriteLine($"Ingrese modelo del articulo {i+1}");
                string modelo = Console.ReadLine();
                Console.WriteLine($"Ingrese tipo del articulo {i+1}");
                string tipo = Console.ReadLine();
                Console.WriteLine($"Ingrese marca del articulo {i+1}");
                string marca = Console.ReadLine();
                Console.WriteLine($"Ingrese precio del articulo {i+1}");
                int precio = Convert.ToInt32(Console.ReadLine());
                Tienda newTienda = new Tienda(modelo, tipo, marca, precio);
                listaProductos[i] = newTienda;
            }
            Console.WriteLine("┌────────────────────────────────────────────┐");
            Console.WriteLine("│      Articulos guardados exitosamente      │");
            Console.WriteLine("└────────────────────────────────────────────┘");
            foreach (Tienda articulo in listaProductos)
            {
                Console.WriteLine($"el Articulo {articulo.Modelo} es un {articulo.Tipo} de la marca {articulo.Marca} y tiene un precio de {articulo.Precio}");
            }
        }
    }
}
