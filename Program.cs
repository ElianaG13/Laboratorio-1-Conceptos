using System;

namespace Laboratorio_1_Conceptos
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int sum2 = 0;
            string nombre, apellido;
            int edad;
            for (int i = 0; i < 5; i++) 


            Console.WriteLine("Bienvenido a C#");
            Console.WriteLine("Ingrese su Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine($"Bienvenido al Sistema: {nombre} {apellido}  Tu edad es: {edad}");


           
           

        }
    }
}
