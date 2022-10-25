
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Introduzca una cadena de al menos 40 caracteres.");
                string? cadena = Console.ReadLine();

                while (cadena == null || cadena.Length < 40)
                {
                    Console.WriteLine($"La cadena posee únicamente {cadena.Length} caracteres. Por favor, introduzca una nueva cadena con más de 40 caracteres.");
                    cadena = Console.ReadLine();
                }
                Console.WriteLine("-----------------------");
                Console.WriteLine("1. Sustituir palabra");
                Console.WriteLine("2. Buscar texto");
                Console.WriteLine("3. Buscar texto inicio");
                Console.WriteLine("Otra tecla: Salir");
                Console.WriteLine("-----------------------");
                string? opcion;
                do
                {
                    Console.WriteLine("Introduzca una opción");
                    opcion = Console.ReadLine();
                } while (opcion == null);
                switch (opcion)
                {
                    case "1":
                        string[] palabras;
                        do
                        {
                            Console.WriteLine("Introduzca dos palabras separadas por un espacio.");
                            string? cadenapalabras = Console.ReadLine();
                            palabras = (cadenapalabras != null) ? cadenapalabras.Split(" ") : null;
                        } while (palabras == null || palabras.Length != 2);
                        cadena = cadena.Replace(palabras[0], palabras[1]);
                        Console.WriteLine(cadena);
                        break;
                    case "2":
                        string? busqueda;
                        do
                        {
                            Console.WriteLine("Introduzca un texto para buscar en la cadena");
                            busqueda = Console.ReadLine();
                        } while (busqueda == null || busqueda.Length == 0);
                        if (cadena.Contains(busqueda))
                        {
                            Console.WriteLine("La cadena contiene la búsqueda");
                        }
                        else
                        {
                            Console.WriteLine("La cadena no contiene la búsqueda");
                        }
                        break;
                    case "3":
                        string? textoInicio;
                        do
                        {
                            Console.WriteLine("Introduzca un texto para buscar al inicio de la cadena");
                            textoInicio = Console.ReadLine();
                        } while (textoInicio == null || textoInicio.Length == 0);
                        if (textoInicio == cadena.Substring(0, textoInicio.Length))
                        {
 
                            Console.WriteLine("La cadena empieza por el texto.");
                        }
                        else
                        {
                            Console.WriteLine("La cadena no empieza por el texto.");
                        }
                        break;
                    default:
                        Console.WriteLine("Cerrando");
                        continuar = false;
                        break;
                }

            }
        }
    }
}
