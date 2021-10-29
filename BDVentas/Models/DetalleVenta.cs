using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDBVentas.Models
{
    //public DbSet <DetalleVenta> detalleVentas { get; set; }
    [Table("detalle_venta")]
    public class DetalleVenta
    {
        public int Iddetalle_venta { get; set; }

        public int Idventa { get; set; }
        [ForeignKey("Idventa")]
        public Venta Venta { get; set; }
        public int Iddetalle_ingreso { get; set; }
        [ForeignKey("Iddetalle_ingreso")]
        public Detalle_ingreso Detalle_ingreso { get; set; }
        
        public int Cantidad { get; set; }

        [Required]
        public decimal Precio_venta { get; set; }
        public int Descuento { get; set; }
    }
}
