using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mserinaEXT3.dtos
{
    /// <summary>
    /// Clase que contiene los atributos y metodos de la clase Pedidos
    /// msm - 040324
    /// </summary>
    internal class Pedidos
    {
        //campos
        long id = 0;
        string nombreProducto = "aaa";
        int CantidadProducto = 0;
        DateTime fechaDeseada;

        //getters and setters
        public long Id { get => id; set => id = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto1 { get => CantidadProducto; set => CantidadProducto = value; }
        public DateTime FechaDeseada { get => fechaDeseada; set => fechaDeseada = value; }

        //controladores
        public Pedidos(long id, string nombreProducto, int cantidadProducto, DateTime fechaDeseada)
        {
            this.id = id;
            this.nombreProducto = nombreProducto;
            CantidadProducto = cantidadProducto;
            this.fechaDeseada = fechaDeseada;
        }

        public Pedidos()
        {

        }

    }
}
