using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.API.Models
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; } // Clave primaria

        [Required]
        [MaxLength(100)]
        public string NombreProveedor { get; set; }

        [Required]
        [MaxLength(150)]
        public string CorreoElectronicoProveedor { get; set; }

        [Required]
        [MaxLength(15)]
        public string TelefonoProveedor { get; set; }
    }
}
