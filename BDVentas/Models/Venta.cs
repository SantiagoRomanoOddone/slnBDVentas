using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDVentas.Models
{
    public class Venta
    {

        public int IdTrabajador { get; set; }




        // Para trabajador
        [ForeignKey("IdTrabajador")]
        public Trabajador Trabajador { get; set; }
    }
}
