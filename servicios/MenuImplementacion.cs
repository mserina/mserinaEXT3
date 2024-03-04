using mserinaEXT3.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mserinaEXT3.servicios
{
    /// <summary>
    /// Contiene la logica de los metodos del servicio menu
    /// msm - 040324
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYRespuesta()
        {
            int opcionSeleccionada;

            Console.WriteLine("###################");
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("0[] Cerrar Menu");
            Console.WriteLine("1[] Modo Gerente");
            Console.WriteLine("2[] Modo Empleado");
            Console.WriteLine("###################");

            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;
        }

        private int menuGerente()
        {
            int opcionSeleccionada;

            Console.WriteLine("###################");
            Console.WriteLine("MENU GERENTE");
            Console.WriteLine("0[] Cerrar");
            Console.WriteLine("1[] Añadir ventas");
            Console.WriteLine("2[] Calcular total ventas diario");
            Console.WriteLine("###################");

            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;
        }

        private int menuEmpleado()
        {
            int opcionSeleccionada;

            Console.WriteLine("###################");
            Console.WriteLine("MENU EMPLEADO");
            Console.WriteLine("0[] Cerrar");
            Console.WriteLine("1[] Mostrar ventas");
            Console.WriteLine("2[] Crear pedidos");
            Console.WriteLine("###################");

            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;
        }

        public void menuGerenteMostrar(List<Ventas> listaVentas)
        {
            GerenteInterfaz gerente = new GerenteImplementacion();
            bool cerrarMenu = false;
            int opcionSeleccionada;

            Console.WriteLine(" ");
            while (!cerrarMenu)
            {
                opcionSeleccionada = menuGerente();

                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        gerente.añadirVentas(listaVentas);
                        cerrarMenu = true;
                        break;
                    case 2:

                        cerrarMenu = true;
                        break;
                }

            }
            Console.WriteLine(" ");
        }

        public void menuEmpleadoMostrar(List<Ventas> listaVentas, List<Pedidos> listaPedidos)
        {
            EmpleadoInterfaz empleado = new EmpleadoImplementacion();
            bool cerrarMenu = false;
            int opcionSeleccionada;

            Console.WriteLine(" ");
            while (!cerrarMenu)
            {
                opcionSeleccionada = menuEmpleado();

                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        empleado.mostrarVentas(listaVentas);
                        cerrarMenu = true;
                        break;
                    case 2:
                        empleado.crearPedido(listaPedidos);
                        cerrarMenu = true;
                        break;
                }

            }
            Console.WriteLine(" ");
        }

    }
}
