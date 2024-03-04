using mserinaEXT3.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mserinaEXT3.servicios
{
    /// <summary>
    /// Contiene la cabezerta de los metodos del servicio gerente
    /// msm - 040324
    /// </summary>
    internal interface GerenteInterfaz
    {
        /// <summary>
        /// Metodo que añade ventas
        /// msm - 040324
        /// </summary>
        /// <param name="listaVentas"></param>
        public void añadirVentas(List<Ventas> listaVentas);

        /*
        public void calcularVentasDiario();
        */
    }
}
