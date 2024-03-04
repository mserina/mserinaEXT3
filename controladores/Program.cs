using mserinaEXT3.dtos;
using mserinaEXT3.servicios;

namespace mserinaEXT3
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// msm - 0403024
    /// </summary>
    /// <param name="args"></param>
    class Program
    {
        /// <summary>
        /// Metodo que contiene el flujo de la aplicacion
        /// msm - 0403024
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {
            List<Pedidos> listaPedidos = new List<Pedidos>();
            List<Ventas> listaVentas = new List<Ventas>();


            MenuInterfaz menu = new MenuImplementacion();

            bool cerrarMenu = false;
            int opcionSeleccionada;


            Console.WriteLine(" ");
            while (!cerrarMenu) 
            {
                opcionSeleccionada = menu.mostrarMenuYRespuesta();

                switch( opcionSeleccionada )
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        menu.menuGerenteMostrar(listaVentas);
                        break;
                    case 2:
                        menu.menuEmpleadoMostrar(listaVentas, listaPedidos);
                        break;
                }
               
            }
            Console.WriteLine(" ");
        }
    }
}