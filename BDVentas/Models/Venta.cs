using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDVentas.Models
{
    [Table("Ventas")]
    
    public class Venta
    {
       
        [Key]
        public int idventa { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public int idcliente { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public int idtrabajador { get; set; }

        [Required]
        [Column(TypeName = "date")]
        [MaxLength(50)]
        public DateTime fecha { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string tipo_comprobante { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string serie { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string correlativo { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string igv { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string estado { get; set; }



        //ForeignKeys

        [ForeignKey("idcliente")]
        public Cliente cliente { get; set; }

        [ForeignKey("iddetalle_venta")]
        public Detalle_venta detalle_venta { get; set; }

        [ForeignKey("idtrabajador")]
        public Trabajador trabajador { get; set; }

        public int IdTrabajador { get; set; }
      



        
    }
}
