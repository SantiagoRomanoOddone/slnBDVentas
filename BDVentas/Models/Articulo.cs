using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDVentas.Models
{
    [Table("Articulo")]
    public class Articulo
    {
        [Key]
        public int IdArticulo { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        public string Codigo { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column(TypeName = "varBinary")]
        [MaxLength(50)]
        public byte[] Imagen { get; set; }
        public int IdCategoria { get; set; }
        public int IdPresentacion { get; set; }

        //[ForeignKey("IdCategoria")]
        //public Categoria categoria { get; set; }

        //[ForeignKey("IdPresentacion")]
        //public Presentacion presentacion { get; set; }

        [ForeignKey("DetalleIngreso")]
        public DetalleIngreso detalleIngreso { get; set; }
    }
}
