using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFarWest.Models
{
    [Table("Provincias")]
    public class Provincia
    {
        public int ProvinciaId { get; set; }
        public string NombreProvincia { get; set; }

    }
}