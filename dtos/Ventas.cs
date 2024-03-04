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
    internal class Ventas
    {

        //Campos
        long id = 0;
        int importe = 0;
        DateTime fechaInstante = DateTime.Now;
       

        //getters and setters
        public long Id { get => id; set => id = value; }
        public int Importe { get => importe; set => importe = value; }
        public DateTime FechaInstante { get => fechaInstante; set => fechaInstante = value; }


        //Constructores
        public Ventas(long id, int importe)
        {
            this.id = id;
            this.importe = importe;
            
        }

        public Ventas()
        {

        }



    }
}
