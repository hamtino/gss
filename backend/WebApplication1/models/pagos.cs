using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.models
{
    public class pagos
    {
        public int ID { get; set; }

        public DateTime? FECHA { get; set; }

        public decimal? VALOR { get; set; }

        public int? alquilerId { get; set; }
    }
}
