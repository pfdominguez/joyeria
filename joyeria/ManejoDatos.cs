using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joyeria
{
    class ManejoDatos
    {
        static int CantidadArticulos = 15;
        static string[,] matrizProducto = new string[CantidadArticulos, 4];
        static int[,] matrizInventario = new int[CantidadArticulos, 4];
        static int[,] matrizFacturacion = new int[CantidadArticulos, 4];
        static string[] arrayIndice = new string[8];
        static string[] arrayIndiceFacturacion = new string[10];


        //Funcion para iniciar el programa
        public static void IniciarPrograma()
        {
            LlenarMatrizProducto();
            LlenarMatrizInventario();
            LlenarArrayIndice();
            LlenarIndiceFacturación();
            LlenarMatrizFacturación();

            bool seguirEnElPrograma = true;

            do
            {
                seguirEnElPrograma = Menu.MenuPrincipal();

            } while (seguirEnElPrograma == true);

        }

        public static void LlenarMatrizProducto()
        {

            //id
            matrizProducto[0, 0] = "1";
            matrizProducto[1, 0] = "2";
            matrizProducto[2, 0] = "3";
            matrizProducto[3, 0] = "4";
            matrizProducto[4, 0] = "5";
            matrizProducto[5, 0] = "6";
            matrizProducto[6, 0] = "7";
            matrizProducto[7, 0] = "8";
            matrizProducto[8, 0] = "9";
            matrizProducto[9, 0] = "10";

            matrizProducto[10, 0] = string.Empty;
            matrizProducto[11, 0] = string.Empty;
            matrizProducto[12, 0] = string.Empty;
            matrizProducto[13, 0] = string.Empty;
            matrizProducto[14, 0] = string.Empty;

            //´productos
            matrizProducto[0, 1] = "Collar Infinity";
            matrizProducto[1, 1] = "Aros Gota";
            matrizProducto[2, 1] = "Pulcera Romia";
            matrizProducto[3, 1] = "Aros Corazon";
            matrizProducto[4, 1] = "Collar Doble";
            matrizProducto[5, 1] = "Dije Delfin";
            matrizProducto[6, 1] = "Dije Yin Yang";
            matrizProducto[7, 1] = "Anillo Flecha";
            matrizProducto[8, 1] = "Collar Pluma";
            matrizProducto[9, 1] = "Dije Corona";
            matrizProducto[10, 1] = string.Empty;
            matrizProducto[11, 1] = string.Empty;
            matrizProducto[12, 1] = string.Empty;
            matrizProducto[13, 1] = string.Empty;
            matrizProducto[14, 1] = string.Empty;

            // tipo
            matrizProducto[0, 2] = "Collares";
            matrizProducto[1, 2] = "Aros";
            matrizProducto[2, 2] = "Pulceras";
            matrizProducto[3, 2] = "Aros";
            matrizProducto[4, 2] = "Collares";
            matrizProducto[5, 2] = "Dijes";
            matrizProducto[6, 2] = "Dijes";
            matrizProducto[7, 2] = "Anillos";
            matrizProducto[8, 2] = "Collares";
            matrizProducto[9, 2] = "Dijes";
            matrizProducto[10, 2] = string.Empty;
            matrizProducto[11, 2] = string.Empty;
            matrizProducto[12, 2] = string.Empty;
            matrizProducto[13, 2] = string.Empty;
            matrizProducto[14, 2] = string.Empty;


            //material
            matrizProducto[0, 3] = "Plata 925";
            matrizProducto[1, 3] = "Oro Blanco 750";
            matrizProducto[2, 3] = "Oro 750";
            matrizProducto[3, 3] = "Acero";
            matrizProducto[4, 3] = "Acero";
            matrizProducto[5, 3] = "Plata 925";
            matrizProducto[6, 3] = "Plata 925";
            matrizProducto[7, 3] = "Acero";
            matrizProducto[8, 3] = "Oro Blanco 750";
            matrizProducto[9, 3] = "Acero";
            matrizProducto[10, 3] = string.Empty;
            matrizProducto[11, 3] = string.Empty;
            matrizProducto[12, 3] = string.Empty;
            matrizProducto[13, 3] = string.Empty;
            matrizProducto[14, 3] = string.Empty;

        }

        public static void LlenarMatrizInventario()
        {
            matrizInventario[0, 0] = 2500;
            matrizInventario[1, 0] = 1750;
            matrizInventario[2, 0] = 2000;
            matrizInventario[3, 0] = 600;
            matrizInventario[4, 0] = 700;
            matrizInventario[5, 0] = 900;
            matrizInventario[6, 0] = 1200;
            matrizInventario[7, 0] = 300;
            matrizInventario[8, 0] = 3000;
            matrizInventario[9, 0] = 250;



            matrizInventario[0, 1] = 0;
            matrizInventario[1, 1] = 10;
            matrizInventario[2, 1] = 5;
            matrizInventario[3, 1] = 20;
            matrizInventario[4, 1] = 0;
            matrizInventario[5, 1] = 16;
            matrizInventario[6, 1] = 22;
            matrizInventario[7, 1] = 30;
            matrizInventario[8, 1] = 0;
            matrizInventario[9, 1] = 25;


            matrizInventario[0, 2] = 3;
            matrizInventario[1, 2] = 5;
            matrizInventario[2, 2] = 2;
            matrizInventario[3, 2] = 10;
            matrizInventario[4, 2] = 8;
            matrizInventario[5, 2] = 4;
            matrizInventario[6, 2] = 15;
            matrizInventario[7, 2] = 20;
            matrizInventario[8, 2] = 1;
            matrizInventario[9, 2] = 17;


            matrizInventario[0, 3] = 2000;
            matrizInventario[1, 3] = 1200;
            matrizInventario[2, 3] = 1625;
            matrizInventario[3, 3] = 300;
            matrizInventario[4, 3] = 550;
            matrizInventario[5, 3] = 600;
            matrizInventario[6, 3] = 890;
            matrizInventario[7, 3] = 185;
            matrizInventario[8, 3] = 2600;
            matrizInventario[9, 3] = 160;

        }

        public static void LlenarArrayIndice()
        {
            arrayIndice[0] = "ID";
            arrayIndice[1] = "Nombre";
            arrayIndice[2] = "Categoria";
            arrayIndice[3] = "Material";
            arrayIndice[4] = "Precio";
            arrayIndice[5] = "Stock";
            arrayIndice[6] = "CantVe";
            arrayIndice[7] = "Costo";

        }

        public static void LlenarMatrizFacturación()
        {
            matrizFacturacion[0, 0] = 1;
            matrizFacturacion[1, 0] = 2;
            matrizFacturacion[2, 0] = 3;
            matrizFacturacion[3, 0] = 4;
            matrizFacturacion[4, 0] = 5;
            matrizFacturacion[5, 0] = 6;
            matrizFacturacion[6, 0] = 7;
            matrizFacturacion[7, 0] = 8;
            matrizFacturacion[8, 0] = 9;
            matrizFacturacion[9, 0] = 10;

            for (int i = 0; i < matrizFacturacion.GetLength(0); i++)
            {
                matrizFacturacion[i, 1] = matrizInventario[i, 0] * matrizInventario[i, 2];
                matrizFacturacion[i, 2] = (matrizInventario[i, 0] * matrizInventario[i, 2]) - (matrizInventario[i, 2] * matrizInventario[i, 3]);
            }
        }

        public static void LlenarIndiceFacturación()
        {
            arrayIndiceFacturacion[0] = "ID";
            arrayIndiceFacturacion[1] = "Nombre";
            arrayIndiceFacturacion[2] = "Categoria";
            arrayIndiceFacturacion[3] = "Material";
            arrayIndiceFacturacion[4] = "Precio";
            arrayIndiceFacturacion[5] = "Stock";
            arrayIndiceFacturacion[6] = "CantVe";
            arrayIndiceFacturacion[7] = "Costo";
            arrayIndiceFacturacion[8] = "Venta";
            arrayIndiceFacturacion[9] = "Gcia";
        }

        // Las funciones del programa que se relacionan con las matrices/arrays

        /// <summary>
        /// Muestra los nombres de las columnas de la matriz
        /// </summary>
        /// <param name="arrayaux"></param>
        public static void MostrarIndiceMatrizProdeInv()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Magenta;
            for (int i = 0; i < arrayIndice.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("| ");
                    Console.Write("{0,-5}  | ", arrayIndice[i]);
                }
                else if (i >= 1 & i < 4)
                {
                    Console.Write("{0,-15}  | ", arrayIndice[i]);
                }
                else
                    Console.Write("{0,-6}  | ", arrayIndice[i]);
            }
        }

        /// <summary>
        /// Indice para mostrar los datos de facturación
        /// </summary>
        public static void MostrarIndiceMatrizFacturacion()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Magenta;
            for (int i = 0; i < arrayIndiceFacturacion.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write("| ");
                    Console.Write("{0,-5}  | ", arrayIndiceFacturacion[i]);
                }
                else if (i >= 1 & i < 4)
                {
                    Console.Write("{0,-15}  | ", arrayIndiceFacturacion[i]);
                }
                else
                    Console.Write("{0,-6}  | ", arrayIndiceFacturacion[i]);
            }
        }

        /// <summary>
        /// Funcion para mostrar la información de la matriz + facturación
        /// </summary>
        /// <param name="fila"></param>
        public static void MostrarDatosMatrizFacturacion(int fila)
        {
            Console.Write("| ");

            for (int j = 0; j < matrizProducto.GetLength(1); j++)
            {
                if (j < 1)
                    Console.Write("{0,-5}  | ", matrizProducto[fila, j]);
                else
                    Console.Write("{0,-15}  | ", matrizProducto[fila, j]);
            }

            for (int j = 0; j < matrizProducto.GetLength(1); j++)
            {
                Console.Write("{0,-6}  | ", matrizInventario[fila, j]);
            }

            for (int i = 1; i < 3; i++)
            {
                Console.Write("{0,-6}  | ", matrizFacturacion[fila, i]);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Función para mostrar la información de la matriz
        /// </summary>
        /// <param name="i"></param>
        public static void MostrarDatosMatriz(int fila)
        {
            Console.Write("| ");

            for (int j = 0; j < matrizProducto.GetLength(1); j++)
            {
                if (j < 1)
                    Console.Write("{0,-5}  | ", matrizProducto[fila, j]);
                else
                    Console.Write("{0,-15}  | ", matrizProducto[fila, j]);
            }

            for (int j = 0; j < matrizProducto.GetLength(1); j++)
            {
                Console.Write("{0,-6}  | ", matrizInventario[fila, j]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Muestra todos los productos 
        /// </summary>
        /// <param name="matrizAux"></param>
        /// <param name="matrizAux1"></param>
        /// <param name="arrayaux"></param>
        public static void MostrarTodos()
        {
            Menu.DibujarEncabezado("Diamond on");

            MostrarIndiceMatrizProdeInv();

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < matrizProducto.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(matrizProducto[i, 0]))
                {
                    MostrarDatosMatriz(i);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        /// <summary>
        /// Muestra todos los productos + info de facturación
        /// </summary>
        public static void MostrarTodosFacturacion()
        {
            Menu.DibujarEncabezado("Diamond on");

            MostrarIndiceMatrizFacturacion();

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < matrizProducto.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(matrizProducto[i, 0]))
                {
                    MostrarDatosMatrizFacturacion(i);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        /// <summary>
        /// Muestra los productos según la categoria elegida
        /// </summary>
        /// <param name="categoriaprod"></param>
        public static void MostrarSegunCategoria(string categoriaprod)
        {
            Menu.DibujarEncabezado("Diamond on");
            MostrarIndiceMatrizProdeInv();

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < matrizProducto.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(matrizProducto[i, 0]))
                {
                    if (matrizProducto[i, 2] == categoriaprod)
                    {
                        MostrarDatosMatriz(i);
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();


        }

        /// <summary>
        /// Muestra productos según stock
        /// </summary>
        /// <param name="stock"></param>
        public static void MostrarSegunStock(int stock)
        {
            Menu.DibujarEncabezado("Diamond on");
            MostrarIndiceMatrizProdeInv();

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < matrizProducto.GetLength(0); i++)
            {
                if (!string.IsNullOrEmpty(matrizProducto[i, 0]))
                {
                    if (stock == 0)
                    {
                        if (matrizInventario[i, 1] > stock)
                        {
                            MostrarDatosMatriz(i);
                        }
                    }
                    else
                    {
                        if (matrizInventario[i, 1] < stock)
                        {
                            MostrarDatosMatriz(i);
                        }
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();


        }

        /// <summary>
        /// Búsqueda por ID del producto
        /// </summary>
        /// <param name="mensaje"></param>
        public static void BusquedaPorID(string mensaje)
        {
            string datoIngresado;
            int cantFilas = matrizProducto.GetLength(0) - 1;
            bool datoEncontrado = false;

            Menu.DibujarEncabezado("Diamond on");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(mensaje);

            datoIngresado = Console.ReadLine();

            MostrarIndiceMatrizProdeInv();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < matrizProducto.GetLength(0); i++)
            {
                if (matrizProducto[i, 0].Contains(datoIngresado))
                {
                    MostrarDatosMatriz(i);
                    datoEncontrado = true;
                }
            }
            if (datoEncontrado == false)
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("El ID ingresado no existe");
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();

        }

        /// <summary>
        /// Búsqueda por nombre del producto
        /// </summary>
        /// <param name="mensaje"></param>
        public static void BusquedaPorNombre(string mensaje)
        {
            string datoIngresado;
            int cantFilas = matrizProducto.GetLength(0) - 1;
            bool datoEncontrado = false;

            Menu.DibujarEncabezado("Diamond on");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(mensaje);

            datoIngresado = Funciones.ValidarString(Console.ReadLine());

            MostrarIndiceMatrizProdeInv();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < matrizProducto.GetLength(0); i++)
            {
                if (matrizProducto[i, 1].ToUpper().Trim().Contains(datoIngresado.ToUpper().Trim()))
                {
                    MostrarDatosMatriz(i);
                    datoEncontrado = true;
                }
            }
            if (datoEncontrado == false)
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("El nombre ingresado no existe");
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();
        }

        /// <summary>
        /// Función para cargar un nuevo producto.
        /// Primero valida que en la matriz haya espacio para agregar un producto
        /// </summary>
        public static void CargaDeNuevoProducto()
        {
            bool espaciodisponible = true;
            int espacioVacio = 1;
            bool agregarOtro = true;
            string consultaUsuario;


            while (agregarOtro == true)
            {
                Console.Clear();

                espaciodisponible = false;

                for (int i = 0; i < matrizProducto.GetLength(0); i++)
                {
                    if (string.IsNullOrEmpty(matrizProducto[i, 0]))
                    {
                        espacioVacio = i;
                        espaciodisponible = true;
                    }
                    else if (i == matrizProducto.GetLength(0) - 1 & espaciodisponible != true)
                    {
                        espaciodisponible = false;
                    }

                }

                if (espaciodisponible == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se puede incorporar un producto nuevo por falta de espacio. \nContactese con su administrador para ampliar el mismo.");
                    Console.ReadKey();
                    agregarOtro = false;

                }
                else
                {
                    Menu.DibujarEncabezado("Diamond on");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    AgregarModificarProductoMatrizProductoIDyNombre("Ingrese número de ID", 0, espacioVacio);
                    Console.Clear();

                    Menu.DibujarEncabezado("Diamond on");
                    Console.ForegroundColor = ConsoleColor.Yellow;


                    AgregarModificarProductoMatrizProductoIDyNombre("Ingrese nombre", 1, espacioVacio);
                    Console.Clear();

                    Menu.DibujarEncabezado("Diamond on");
                    Console.ForegroundColor = ConsoleColor.Yellow;


                    SeleccionCategoriaProducto("Seleccione la categoria", espacioVacio);
                    Console.Clear();

                    Menu.DibujarEncabezado("Diamond on");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    SeleccionMaterialProducto("Seleccione el material", espacioVacio);
                    Console.Clear();

                    Menu.DibujarEncabezado("Diamond on");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    AgregarModificarProductoMatrizInventario("Ingrese precio", 0, espacioVacio);
                    Console.Clear();

                    Menu.DibujarEncabezado("Diamond on");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    AgregarModificarProductoMatrizInventario("Ingrese stock", 1, espacioVacio);
                    Console.Clear();

                    Menu.DibujarEncabezado("Diamond on");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    AgregarModificarProductoMatrizInventario("Ingrese cantidad vendida", 2, espacioVacio);
                    Console.Clear();

                    Menu.DibujarEncabezado("Diamond on");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    AgregarModificarProductoMatrizInventario("Ingrese el costo", 3, espacioVacio);

                    Console.Clear();

                    MostrarTodos();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("¿Desea agregar otro producto? Escriba S por si o N por no");
                    consultaUsuario = Funciones.ValidarSoN(Console.ReadLine());

                    if (consultaUsuario == "n")
                    {
                        agregarOtro = false;
                    }

                }

            }

        }

        /// <summary>
        /// Esta función se utiliza para agregar un producto nuevo o ya sea para modificarlo
        /// en las columnas de ID y nombre.
        /// La columna de ID valida que no haya duplicados
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="columna"></param>
        /// <param name="fila"></param>
        public static void AgregarModificarProductoMatrizProductoIDyNombre(string mensaje, int columna, int fila)
        {
            string datoIngresado;
            Console.WriteLine(mensaje);

            if (columna == 0)
            {
                datoIngresado = Funciones.ValidarIDseaNumerico(datoIngresado = Console.ReadLine());
            }
            else
            {
                datoIngresado = Funciones.ValidarString(Console.ReadLine());
            }

            bool repetido = true;

            while (repetido == true)
            {
                repetido = false;

                for (int i = 0; i < matrizProducto.GetLength(0); i++)
                {
                    if (matrizProducto[i, columna] == datoIngresado)
                    {
                        repetido = true;
                    }

                }

                if (repetido == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error, el dato ingresado ya existe");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(mensaje);

                    if (columna == 0)
                    {
                        datoIngresado = Funciones.ValidarIDseaNumerico(datoIngresado = Console.ReadLine());
                    }
                    else
                    {
                        datoIngresado = Funciones.ValidarString(Console.ReadLine());
                    }

                }

            }


            matrizProducto[fila, columna] = datoIngresado;

            if (columna == 0)
            {
                matrizFacturacion[fila, columna] = int.Parse(datoIngresado);
            }


        }

        /// <summary>
        /// Funcion para seleccionar la categoría ya sea en nuevo producto o modificación
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="fila"></param>
        public static void SeleccionCategoriaProducto(string mensaje, int fila)
        {
            Console.WriteLine(mensaje);
            Menu.OpcionesSubMenuMostrarCategoria(0);
            int opcionIngresada;
            opcionIngresada = Funciones.ValidarEntero(1, 5);

            switch (opcionIngresada)
            {
                case 1:
                    matrizProducto[fila, 2] = "Aros";
                    break;
                case 2:
                    matrizProducto[fila, 2] = "Pulceras";
                    break;
                case 3:
                    matrizProducto[fila, 2] = "Collares";
                    break;
                case 4:
                    matrizProducto[fila, 2] = "Dijes";
                    break;
                case 5:
                    matrizProducto[fila, 2] = "Anillos";
                    break;
            }

        }

        /// <summary>
        /// Funcion para seleccionar el material ya sea nuevo producto o modificación
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="fila"></param>
        public static void SeleccionMaterialProducto(string mensaje, int fila)
        {
            Console.WriteLine(mensaje);
            Menu.OpcionesMaterial();

            int opcionIngresada;
            opcionIngresada = Funciones.ValidarEntero(1, 5);

            switch (opcionIngresada)
            {
                case 1:
                    matrizProducto[fila, 3] = "Plata 925";
                    break;
                case 2:
                    matrizProducto[fila, 3] = "Oro Blanco 750";
                    break;
                case 3:
                    matrizProducto[fila, 3] = "Oro 750";
                    break;
                case 4:
                    matrizProducto[fila, 3] = "Platino 950";
                    break;
                case 5:
                    matrizProducto[fila, 3] = "Acero";
                    break;
            }
        }

        /// <summary>
        /// Funcion para agregar o modificar la información de la matriz inventario
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="columna"></param>
        /// <param name="fila"></param>
        public static void AgregarModificarProductoMatrizInventario(string mensaje, int columna, int fila)
        {
            int datoIngresado;
            Console.WriteLine(mensaje);
            datoIngresado = Funciones.ValidarEnteroIngresado();

            matrizInventario[fila, columna] = datoIngresado;

        }

        /// <summary>
        /// Funcion para buscar la fila del producto que el usuario quiera modificar/eliminar
        /// </summary>
        /// <param name="auxFila"></param>
        /// <returns></returns>
        public static int BuscarFilaProducto(int auxFila)
        {
            string productoModificar;
            bool idExiste = false;

            while (idExiste == false)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ingrese ID del producto");
                productoModificar = Funciones.ValidarString(Console.ReadLine());

                for (int i = 0; i < matrizProducto.GetLength(0); i++)
                {
                    if (matrizProducto[i, 0] == productoModificar)
                    {
                        idExiste = true;
                        auxFila = i;
                    }
                }

                if (idExiste == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error, ID inexistente. \nIngrese ID nuevamente");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            return auxFila;
        }

        /// <summary>
        /// Función para eliminar el producto que el usuario desee
        /// </summary>
        public static void EliminarProducto()
        {
            int filaProducto = 0;
            string confirmar;

            filaProducto = BuscarFilaProducto(filaProducto);

            Menu.DibujarEncabezado("Diamond On");

            ManejoDatos.MostrarIndiceMatrizProdeInv();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            ManejoDatos.MostrarDatosMatriz(filaProducto);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¿Desea eliminar este producto? Escriba S por si o N por no");
            confirmar = Funciones.ValidarSoN(Console.ReadLine());
            Console.WriteLine();

            if (confirmar == "s")
            {
                matrizProducto[filaProducto, 0] = string.Empty;
                matrizProducto[filaProducto, 1] = string.Empty;
                matrizProducto[filaProducto, 2] = string.Empty;
                matrizProducto[filaProducto, 3] = string.Empty;
                matrizInventario[filaProducto, 0] = 0;
                matrizInventario[filaProducto, 1] = 0;
                matrizInventario[filaProducto, 2] = 0;
                matrizInventario[filaProducto, 3] = 0;
                matrizFacturacion[filaProducto, 0] = 0;

                Console.WriteLine("El producto se ha eliminado correctamente");
                Console.ReadKey();
                Console.WriteLine();
                MostrarTodos();
            }

        }

        /// <summary>
        /// Muestra los productos según mayor venta o ganancia
        /// </summary>
        /// <param name="opción"></param>
        /// <param name="mensaje"></param>
        public static void MostrarMatrizFacturaciónSegunMayorVentaOGanancia(int opción, string mensaje)
        {
            int mayorImporte = 0;
            int productoMayorImporte = 0;

            for (int i = 0; i < matrizFacturacion.GetLength(0); i++)
            {
                if (matrizFacturacion[i, opción] > mayorImporte)
                {
                    mayorImporte = matrizFacturacion[i, opción];
                    productoMayorImporte = i;
                }
            }

            Menu.DibujarEncabezado("Diamond On");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(mensaje);

            Console.WriteLine();
            MostrarIndiceMatrizFacturacion();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            MostrarDatosMatrizFacturacion(productoMayorImporte);

            Console.ReadKey();

        }

        /// <summary>
        /// Ordena las matrices según la columna enviada por parámetro (ID, Venta, Ganancia) de mayor a menor
        /// </summary>
        /// <param name="columna"></param>
        public static void OrdenarMatricesMayor(int columna)
        {
            string tempIDProducto;
            string tempNombre;
            string tempCategoria;
            string tempMaterial;
            int tempPrecio;
            int tempStock;
            int tempCantvendida;
            int tempCosto;
            int tempIdFacturacion;
            int tempVenta;
            int tempGanancia;

            for (int i = 0; i < matrizProducto.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrizProducto.GetLength(0); j++)
                {
                    if (matrizFacturacion[i, columna] < matrizFacturacion[j, columna])
                    {
                        tempIDProducto = matrizProducto[i, 0];
                        tempNombre = matrizProducto[i, 1];
                        tempCategoria = matrizProducto[i, 2];
                        tempMaterial = matrizProducto[i, 3];
                        tempPrecio = matrizInventario[i, 0];
                        tempStock = matrizInventario[i, 1];
                        tempCantvendida = matrizInventario[i, 2];
                        tempCosto = matrizInventario[i, 3];
                        tempIdFacturacion = matrizInventario[i, 0];
                        tempVenta = matrizFacturacion[i, 1];
                        tempGanancia = matrizFacturacion[i, 2];

                        matrizProducto[i, 0] = matrizProducto[j, 0];
                        matrizProducto[i, 1] = matrizProducto[j, 1];
                        matrizProducto[i, 2] = matrizProducto[j, 2];
                        matrizProducto[i, 3] = matrizProducto[j, 3];
                        matrizInventario[i, 0] = matrizInventario[j, 0];
                        matrizInventario[i, 1] = matrizInventario[j, 1];
                        matrizInventario[i, 2] = matrizInventario[j, 2];
                        matrizInventario[i, 3] = matrizInventario[j, 3];
                        matrizFacturacion[i, 0] = matrizFacturacion[j, 0];
                        matrizFacturacion[i, 1] = matrizFacturacion[j, 1];
                        matrizFacturacion[i, 2] = matrizFacturacion[j, 2];

                        matrizProducto[j, 0] = tempIDProducto;
                        matrizProducto[j, 1] = tempNombre;
                        matrizProducto[j, 2] = tempCategoria;
                        matrizProducto[j, 3] = tempMaterial;
                        matrizInventario[j, 0] = tempPrecio;
                        matrizInventario[j, 1] = tempStock;
                        matrizInventario[j, 2] = tempCantvendida;
                        matrizInventario[j, 3] = tempCosto;
                        matrizFacturacion[j, 0] = tempIdFacturacion;
                        matrizFacturacion[j, 1] = tempVenta;
                        matrizFacturacion[j, 2] = tempGanancia;

                    }
                }
            }
        }

    }
}
