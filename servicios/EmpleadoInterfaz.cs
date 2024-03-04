using mserinaEXT3.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mserinaEXT3.servicios
{
    /// <summary>
    /// Contiene la cabezerta de los metodos del servicio empleado
    /// msm - 040324
    /// </summary>
    internal interface EmpleadoInterfaz
    {
        /// <summary>
        /// Metodo que muestra ventas
        /// msm - 040324
        /// </summary>
        public void mostrarVentas(List<Ventas> Ventas);

        /// <summary>
        /// Metodo para crear pedidos
        /// msm - 040324
        /// </summary>
        /// <param name="listaPedidos"></param>
        public void crearPedido(List<Pedidos> listaPedidos);

    }
}
