using mserinaEXT3.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mserinaEXT3.servicios
{
    /// <summary>
    /// Contiene la logica de los metodos del servicio empleado
    /// msm - 040324
    /// </summary>
    internal class EmpleadoImplementacion : EmpleadoInterfaz
    {
        static DateTime nombreFichero = DateTime.Now.Date; 
        static string rutaFichero = $"C:\\Users\\csi23-mserina\\Desktop\\{nombreFichero.ToString("ddMMyyyy")}.txt";

        public void mostrarVentas(List<Ventas> listaVentas)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Inserte fecha");
            string fechaString = Console.ReadLine();

            DateTime fechaDate = Convert.ToDateTime(fechaString);

            foreach (Ventas ventas in listaVentas)
            {
                if(ventas.FechaInstante.Date == fechaDate.Date)
                {
                    using(StreamWriter sw = new StreamWriter(rutaFichero, true))
                    {
                        sw.WriteLine("……….");
                        sw.WriteLine($"Ventas numero: {ventas.Id}");
                        sw.WriteLine($"Euros: {ventas.Importe} euros");
                        sw.WriteLine($"Instante de compra:{ventas.FechaInstante.ToString("dd-MM-yyyy hh:mm:ss")}");
                        sw.WriteLine(" ");
                    }
                }
            }
        }

        public void crearPedido(List<Pedidos> listaPedidos)
        {
            string respuesta = "s";
            Console.WriteLine(" ");
            while (respuesta.Equals("s")) 
            {
                Console.WriteLine("Inserte nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Inserte cantidad de productos");
                int cantidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte fecha deseada de entrega (dd-MM-yyyy)");
                string fechaInsertada = Console.ReadLine();
                long id = idCalculado(listaPedidos);

                DateTime fechaInsertadaDate = Convert.ToDateTime(fechaInsertada);

                Pedidos pedidos = new Pedidos(id, nombre, cantidad, fechaInsertadaDate);
                listaPedidos.Add(pedidos);

                Console.WriteLine(" ");
                Console.WriteLine("¿Quieres seguir insertando pedidos?");
                respuesta = Console.ReadLine();
            }

            foreach (Pedidos pedidos in listaPedidos)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Producto: " + pedidos.NombreProducto);
                Console.WriteLine("Cantidad: " + pedidos.CantidadProducto1 + " unidades");
                Console.WriteLine("Fecha entrega: " + pedidos.FechaDeseada.ToString("dd-MM-yyyy"));
                Console.WriteLine(" ");
            }

        }

        private long idCalculado(List<Pedidos> listaPedidos)
        {
            long idCalculo = 0;
            long tamañoLista = listaPedidos.Count;

            if (listaPedidos.Count == 0)
            {
                idCalculo = 1;
            }
            else
            {
                idCalculo = tamañoLista + 1;
            }

            return idCalculo;
        }
    }
}
