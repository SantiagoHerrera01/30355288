using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.API.Models
{
    /// <summary>
    /// Representa a un cliente en la tienda.
    /// </summary>
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; } // Clave primaria

        [Required]
        [MaxLength(100)]
        public string NombreCliente { get; set; }

        [Required]
        [MaxLength(150)]
        public string CorreoElectronicoCliente { get; set; }

        [Required]
        [MaxLength(15)]
        public string TelefonoCliente { get; set; }

        // Relación con Ventas (Un Cliente puede tener muchas Ventas)
        //public ICollection<Venta> Ventas { get; set; }
    }
}

