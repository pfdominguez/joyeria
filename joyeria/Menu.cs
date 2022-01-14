using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joyeria
{
    class Menu
    {
        public static bool MenuPrincipal()
        {
            Console.Clear();
            int opcionIngresada;
            bool seguirEnElPrograma = true;

            DibujarEncabezado("Diamond on");

            OpcionesMenuPrincipal();

            opcionIngresada = Funciones.ValidarEntero(1, 7);
            Console.Clear();

            switch (opcionIngresada)
            {
                case 1:

                    SubMenuMostrarInformacion();
                    break;

                case 2:

                    SubMenuBuscarProducto();
                    break;

                case 3:

                    ManejoDatos.CargaDeNuevoProducto();
                    break;

                case 4:

                    SubMenuModificarProducto();
                    break;

                case 5:

                    ManejoDatos.EliminarProducto();
                    break;

                case 6:

                    ManejoDatos.LlenarMatrizFacturación();
                    SubMenuFacturación();
                    break;

                case 7:

                    seguirEnElPrograma = false;
                    break;

            }

            return seguirEnElPrograma;

        }

        static void SubMenuMostrarInformacion()
        {
            int opcionIngresada;
            bool seguirEnElSubmenu = true;

            do
            {
                Console.Clear();

                DibujarEncabezado("Diamond on");

                OpcionesSubMenuMostrarInformacion();

                opcionIngresada = Funciones.ValidarEntero(1, 4);

                Console.Clear();
                switch (opcionIngresada)
                {
                    case 1:

                        ManejoDatos.MostrarTodos();
                        break;

                    case 2:

                        SubMenuMostrarInformacionCategoria();
                        break;

                    case 3:

                        SubMenuMostrarInformacionStock();
                        break;

                    case 4:

                        seguirEnElSubmenu = false;
                        break;
                }


            } while (seguirEnElSubmenu == true);

        }

        static void SubMenuMostrarInformacionCategoria()
        {
            int opcionIngresada;
            bool seguirEnElSubmenu = true;

            do
            {
                Console.Clear();

                DibujarEncabezado("Diamond on");

                OpcionesSubMenuMostrarCategoria(1);


                opcionIngresada = Funciones.ValidarEntero(1, 6);

                Console.Clear();
                switch (opcionIngresada)
                {
                    case 1:

                        ManejoDatos.MostrarSegunCategoria("Aros");
                        break;
                    case 2:

                        ManejoDatos.MostrarSegunCategoria("Pulceras");
                        break;

                    case 3:

                        ManejoDatos.MostrarSegunCategoria("Collares");
                        break;

                    case 4:

                        ManejoDatos.MostrarSegunCategoria("Dijes");
                        break;

                    case 5:

                        ManejoDatos.MostrarSegunCategoria("Anillos");
                        break;

                    case 6:

                        seguirEnElSubmenu = false;
                        break;

                }


            } while (seguirEnElSubmenu == true);

        }

        static void SubMenuMostrarInformacionStock()
        {
            int opcionIngresada;
            bool seguirEnElSubmenu = true;

            do
            {
                Console.Clear();

                DibujarEncabezado("Diamond on");

                OpcionesSubMenuMostrarStock();

                opcionIngresada = Funciones.ValidarEntero(1, 6);

                Console.Clear();
                switch (opcionIngresada)
                {
                    case 1:

                        ManejoDatos.MostrarSegunStock(0);
                        break;

                    case 2:

                        ManejoDatos.MostrarSegunStock(1);
                        break;

                    case 3:

                        seguirEnElSubmenu = false;
                        break;
                }

            } while (seguirEnElSubmenu == true);

        }


        static void SubMenuBuscarProducto()
        {
            int opcionIngresada;
            bool seguirEnElSubmenu = true;

            do
            {
                Console.Clear();

                DibujarEncabezado("Diamond on");

                OpcionesSubMenuBuscarProducto();

                opcionIngresada = Funciones.ValidarEntero(1, 3);

                Console.Clear();
                switch (opcionIngresada)
                {
                    case 1:

                        ManejoDatos.BusquedaPorID("Ingrese ID a buscar");
                        break;
                    case 2:

                        ManejoDatos.BusquedaPorNombre("Ingrese Nombre a Buscar");
                        break;

                    case 3:

                        seguirEnElSubmenu = false;
                        break;


                }


            } while (seguirEnElSubmenu == true);

        }

        static void SubMenuModificarProducto()
        {
            int opcionIngresada;
            bool seguirEnElSubmenu = true;
            int fila = 0;

            do
            {
                DibujarEncabezado("Diamond on");

                fila = ManejoDatos.BuscarFilaProducto(fila);
                string continuar;

                Console.WriteLine();

                ManejoDatos.MostrarIndiceMatrizProdeInv();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                ManejoDatos.MostrarDatosMatriz(fila);

                Console.WriteLine();

                OpcionesModificar();

                opcionIngresada = Funciones.ValidarEntero(1, 8);

                Console.Clear();
                switch (opcionIngresada)
                {
                    case 1:

                        ManejoDatos.AgregarModificarProductoMatrizProductoIDyNombre("Ingrese nuevo ID", 0, fila);
                        break;
                    case 2:

                        ManejoDatos.AgregarModificarProductoMatrizProductoIDyNombre("Ingrese nuevo nombre", 1, fila);
                        break;

                    case 3:

                        ManejoDatos.SeleccionCategoriaProducto("Seleccione categoría nueva", fila);
                        break;

                    case 4:

                        ManejoDatos.SeleccionMaterialProducto("Seleccione material nuevo", fila);
                        break;

                    case 5:

                        ManejoDatos.AgregarModificarProductoMatrizInventario("Ingrese nuevo precio", 0, fila);
                        break;

                    case 6:

                        ManejoDatos.AgregarModificarProductoMatrizInventario("Ingrese nuevo stock", 1, fila);
                        break;

                    case 7:

                        ManejoDatos.AgregarModificarProductoMatrizInventario("Ingrese cantidad vendidas actualizado", 2, fila);
                        break;
                    case 8:

                        ManejoDatos.AgregarModificarProductoMatrizInventario("Ingrese nuevo costo", 3, fila);
                        break;

                }

                Console.Clear();
                Console.WriteLine("El producto se modifico con éxito:");
                Console.WriteLine();

                ManejoDatos.MostrarIndiceMatrizProdeInv();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                ManejoDatos.MostrarDatosMatriz(fila);
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("¿Desea modificar otro producto?.\nIngrese S por si o N");
                continuar = Funciones.ValidarSoN(Console.ReadLine());

                if (continuar == "n")
                {
                    seguirEnElSubmenu = false;
                }

                Console.Clear();

            } while (seguirEnElSubmenu == true);
        }


        static void SubMenuFacturación()
        {
            int opcionIngresada;
            bool seguirEnElSubmenu = true;

            do
            {
                Console.Clear();

                DibujarEncabezado("Diamond on");

                OpcionesSubMenuFacturación();

                opcionIngresada = Funciones.ValidarEntero(1, 5);

                Console.Clear();
                switch (opcionIngresada)
                {
                    case 1:

                        ManejoDatos.MostrarMatrizFacturaciónSegunMayorVentaOGanancia(opcionIngresada, "El producto con mayor venta es:");
                        break;

                    case 2:

                        ManejoDatos.MostrarMatrizFacturaciónSegunMayorVentaOGanancia(opcionIngresada, "El producto con mayor ganancia es:");
                        break;

                    case 3:

                        ManejoDatos.OrdenarMatricesMayor(1);
                        ManejoDatos.MostrarTodosFacturacion();
                        break;

                    case 4:

                        ManejoDatos.OrdenarMatricesMayor(2);
                        ManejoDatos.MostrarTodosFacturacion();
                        break;

                    case 5:

                        seguirEnElSubmenu = false;
                        break;


                }


            } while (seguirEnElSubmenu == true);

        }



        static void OpcionesMenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Menu Principal:");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("1. Mostrar productos");
            Console.WriteLine("2. Buscar producto");
            Console.WriteLine("3. Agregar producto");
            Console.WriteLine("4. Modificar producto");
            Console.WriteLine("5. Eliminar producto");
            Console.WriteLine("6. Facturación");
            Console.WriteLine("7. Salir");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingrese la opción deseada");

            Console.ResetColor();

        }

        static void OpcionesSubMenuMostrarInformacion()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Seccion Mostrar Productos");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("     1. Mostrar todos los productos");
            Console.WriteLine("     2. Mostrar según categoría");
            Console.WriteLine("     3. Mostrar según stock");
            Console.WriteLine("     4. Volver a la opcion anterior");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingrese una opcion");
            Console.ResetColor();

        }

        public static void OpcionesSubMenuMostrarCategoria(int opcion)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            if (opcion == 1)
            {
                Console.WriteLine("Seccion Mostrar Productos");
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("     1. Aros");
            Console.WriteLine("     2. Pulceras");
            Console.WriteLine("     3. Collares");
            Console.WriteLine("     4. Dijes");
            Console.WriteLine("     5. Anillos");
            if (opcion == 1)
            {
                Console.WriteLine("     6. Volver a la opcion anterior");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nIngrese una opcion");
            Console.ResetColor();

        }

        static void OpcionesSubMenuMostrarStock()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Seccion Mostrar Productos");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("     1. Con stock ");
            Console.WriteLine("     2. Sin stock");
            Console.WriteLine("     3. Volver a la opcion anterior");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nIngrese una opcion");
            Console.ResetColor();

        }

        static void OpcionesSubMenuBuscarProducto()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Seccion Buscar producto");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("     1. Buscar por ID");
            Console.WriteLine("     2. Buscar por nombre");
            Console.WriteLine("     3. Volver a la opcion anterior");


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nIngrese una opcion");
            Console.ResetColor();

        }

        static void OpcionesSubMenuFacturación()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Seccion Facturación");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("     1. Mostrar producto con mayor venta");
            Console.WriteLine("     2. Mostrar producto con mayor ganancia");
            Console.WriteLine("     3. Mostrar la facturación por producto ordenada de mayor a menor");
            Console.WriteLine("     4. Mostrar la ganancia por producto ordenada de mayor a menor");
            Console.WriteLine("     5. Volver a la opcion anterior");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nIngrese una opcion");
            Console.ResetColor();

        }

        static void OpcionesModificar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Seleccione que desea modificar");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("     1. ID");
            Console.WriteLine("     2. Nombre");
            Console.WriteLine("     3. Categoria");
            Console.WriteLine("     4. Material");
            Console.WriteLine("     5. Precio");
            Console.WriteLine("     6. Stock");
            Console.WriteLine("     7. Cantidad Vendidas");
            Console.WriteLine("     8. Costo");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nIngrese una opcion");
            Console.ResetColor();
        }

        public static void OpcionesMaterial()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("     1. Plata 925");
            Console.WriteLine("     2. Oro Blanco 750");
            Console.WriteLine("     3. Oro 750");
            Console.WriteLine("     4. Platino 950");
            Console.WriteLine("     5. Acero");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nIngrese una opcion");
            Console.ResetColor();
        }


        // Nombre de la empresa - Encabezado
        public static void DibujarEncabezado(string textAMostrar)
        {
            string titulo = "--------- " + textAMostrar.Trim() + " ---------- ";
            string asterisquitos = string.Empty;

            for (int i = 0; i < titulo.Length; i++)
            {
                asterisquitos += "-";
            }

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine(asterisquitos);
            Console.WriteLine(titulo);
            Console.WriteLine(asterisquitos);
            Console.WriteLine();

        }


    }
}
