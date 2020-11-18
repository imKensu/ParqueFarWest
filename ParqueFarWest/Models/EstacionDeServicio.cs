using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFarWest.Models
{
    [Table("EstacionesDeServicios")]
    public class EstacionDeServicio
    {
        [Key]
        public int EstacionId { get; set; }

        public string NombreEstacion { get; set; }

        public int ProvinciaId { get; set; }

        public int LocalidadId { get; set; }

        public string TelefonoDeContacto { get; set; }
    }
}