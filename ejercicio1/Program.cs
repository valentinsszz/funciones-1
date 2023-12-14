using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer una función llamada “producto” que reciba dos números enteros 
            // y que devuelva el producto de ambos. 
            // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida 
            // y muestre por pantalla el monto total a pagar. 
            // Usar la función.Console.WriteLine("Hello World!");
            
            int articulo, cantidadVendida;
            int total;

            Console.WriteLine("Ingrese precio del articulo: ");
            articulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el total vendido: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            total = producto(articulo, cantidadVendida);
            Console.WriteLine("La catidad total a pagar es " + total);
        }

        static int producto(int a, int b){
            int r;     
            r = a * b;
            return r;
        }

            

    }
}
