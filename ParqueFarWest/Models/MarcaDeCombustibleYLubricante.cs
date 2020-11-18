using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFarWest.Models
{
    [Table("MarcasDeCombustiblesYLubricantes")]
    public class MarcaDeCombustibleYLubricante
    {
        [Key]
        public int MarcaId { get; set; }

        public string NombreMarca { get; set; }

    }
}