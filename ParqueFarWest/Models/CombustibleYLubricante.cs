using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFarWest.Models
{
    [Table("CombustiblesYLubricantes")]
    public class CombustibleYLubricante
    {
        [Key]
        public int CombustibleId { get; set; }

        public int TipoDeCombustibleId { get; set; }

        public int MarcaId { get; set; }

        public string Descripcion { get; set; }

    }
}