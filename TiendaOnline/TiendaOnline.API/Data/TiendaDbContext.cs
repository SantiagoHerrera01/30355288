using Microsoft.EntityFrameworkCore;
using TiendaOnline.API.Models;

namespace TiendaOnline.API.Data
{
    /// <summary>
    /// Contexto de la base de datos para la tienda en línea.
    /// </summary>
    public class TiendaDbContext : DbContext
    {
        /// <summary>
        /// Constructor del contexto que recibe opciones de configuración.
        /// </summary>
        /// <param name="options">Opciones de configuración del contexto</param>
        public TiendaDbContext(DbContextOptions<TiendaDbContext> options) : base(options)
        {
        }

        // Definir las tablas de la base de datos (DbSets)
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Detalle_Venta> Detalle_Ventas { get; set; }

    }
}