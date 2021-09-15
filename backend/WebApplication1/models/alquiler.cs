using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.models
{
 
    public partial class alquiler
    {
        public int ID { get; set; }


        public DateTime? FECHA { get; set; }

        public int? TIEMPO { get; set; }


        public decimal? VALORTOTAL { get; set; }


        public decimal? SALDO { get; set; }


        public decimal? ABONOINICIAL { get; set; }


        public string DEVUELTO { get; set; }

        public int? carroId { get; set; }

        public int? clienteId { get; set; }


    }
}
