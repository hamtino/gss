using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.models
{
    [Table("cliente")]
    public partial class cliente
    {
        public int ID { get; set; }

        public int? CEDULA { get; set; }

        public string NOMBRE { get; set; }

        public int? TELEFONO1 { get; set; }

        public int? TELEFONO2 { get; set; }

    }

   

}
