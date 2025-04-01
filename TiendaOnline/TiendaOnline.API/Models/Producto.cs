using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace TiendaOnline.API.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; } // Clave primaria

        [Required]
        [MaxLength(100)]
        public string NombreProducto { get; set; }

        [Required]
        [MaxLength(150)]
        public string PrecioProducto { get; set; }

        [Required]
        [MaxLength(15)]
        public int CantidadProducto { get; set; }
    }
}
