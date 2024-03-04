using mserinaEXT3.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mserinaEXT3.servicios
{
    /// <summary>
    /// Contiene la logica de los metodos del servicio gerente
    /// msm - 040324
    /// </summary>
    internal class GerenteImplementacion : GerenteInterfaz
    {
        public void añadirVentas(List<Ventas> listaVentas)
        {
            Console.WriteLine("Inserte importe de venta");
            int importe = Convert.ToInt32(Console.ReadLine());
            long id = idCalculado(listaVentas);

            Ventas nuevaVenta = new Ventas(id,importe);
            listaVentas.Add(nuevaVenta);
        }

        private long idCalculado(List<Ventas> listaVentas)
        {
            long idCalculo = 0;
            long tamañoLista = listaVentas.Count;

            if (listaVentas.Count == 0)
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
