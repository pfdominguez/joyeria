using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joyeria
{
    class Funciones
    {

        /// <summary>
        /// Valida que la opción ingresada por el usuario sea una opción disponible del menu
        /// </summary>
        /// <param name="opcionMin"></param>
        /// <param name="opcionMax"></param>
        /// <returns></returns>
        public static int ValidarEntero(int opcionMin, int opcionMax)
        {
            int opcion;

            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < opcionMin || opcion > opcionMax)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error,reingrese opcion valida.\nIngrese una opcion entre {0} y {1}", opcionMin, opcionMax);
            }
            Console.ResetColor();

            return opcion;

        }

        /// <summary>
        /// Valida la tecla ingresada por el usuario cuando se consulta si desea continuar con el menu.
        /// </summary>
        /// <param name="auxDatoIngresado"></param>
        /// <returns></returns>
        public static string ValidarSoN(string auxDatoIngresado)
        {
            while (string.IsNullOrEmpty(auxDatoIngresado) || (auxDatoIngresado.ToLower().Trim() != "s" && auxDatoIngresado.ToLower().Trim() != "n"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error,reingrese opcion valida.\nIngrese una opcion entre S o N");
                auxDatoIngresado = Console.ReadLine();
            }
            Console.ResetColor();

            return auxDatoIngresado;

        }

        /// <summary>
        /// Valida que el dato de tipo string no pueda ser nulo o vacio
        /// </summary>
        /// <param name="datoIngresado"></param>
        /// <returns></returns>
        public static string ValidarString(string datoIngresado)
        {

            while (string.IsNullOrEmpty(datoIngresado))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error,reingrese opcion valida.");
                datoIngresado = Console.ReadLine();
            }
            Console.ResetColor();


            return datoIngresado;
        }

        /// <summary>
        /// Valida que no sea vacio el dato ingresado por el usuario
        /// </summary>
        /// <returns></returns>
        public static int ValidarEnteroIngresado()
        {
            int opcion;

            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error,reingrese opcion valida");
            }
            Console.ResetColor();

            return opcion;

        }

        /// <summary>
        /// Valida que el ID ingresado sea númerico para poder tambien asignarlo a la matriz facturación
        /// </summary>
        /// <param name="datoIngresado"></param>
        /// <returns></returns>
        public static string ValidarIDseaNumerico(string datoIngresado)
        {
            int convertido;

            while (!int.TryParse(datoIngresado, out convertido))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El dato ingresado debe ser un número. \n Por favor reingrese ID");
                Console.WriteLine();

                datoIngresado = Console.ReadLine();

            }

            return datoIngresado;
        }

    }
}

