using mserinaEXT3.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mserinaEXT3.servicios
{
    /// <summary>
    /// Contiene la cabezerta de los metodos del servicio menu
    /// msm - 040324
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra y recoge la respuesta del usuario del menu principal
        /// msm - 040324
        /// </summary>
        public int mostrarMenuYRespuesta();

        /// <summary>
        /// Metodo que muestra y recoge la respuesta del usuario del menu gerente
        /// msm - 040324
        /// </summary>
        public void menuGerenteMostrar(List<Ventas> listaVentas);
        
        /// <summary>
        /// Metodo que muestra y recoge la respuesta del usuario del menu empleado
        /// msm - 040324
        /// </summary>
        public void menuEmpleadoMostrar(List<Ventas> listaVentas, List<Pedidos> listaPedidos);
        

    }
}
