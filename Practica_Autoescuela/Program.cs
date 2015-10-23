using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Practica_Autoescuela.clases;

namespace Practica_Autoescuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido Usuario.\n" +
                              "Por favor, introduce tus datos.\n\n");

            Console.WriteLine("Nombre: ");
            var nombre = Console.ReadLine();

            Console.WriteLine("\nEdad: ");
            int edad = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nPermiso Actual: ");
            var permisoactual = Console.ReadLine();

            Console.WriteLine("\n¿Qué permiso quieres obtener?: ");
            var permisopedido = Console.ReadLine();
            
            try
            {
                var usuario = new Usuario()
                {
                    Nombre = nombre,
                    Edad = edad,
                    PermisoActual = permisoactual,
                    PermisoPedido = permisopedido,

                };

                Console.WriteLine("Felicidades, se ha registrado en la autoescuela!!");

            }
            catch (EdadIncorrectaException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (PermisoIncorrectoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (PermisoYaObtenidoException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}
