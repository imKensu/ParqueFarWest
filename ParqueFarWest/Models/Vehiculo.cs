using System.ComponentModel.DataAnnotations.Schema;

namespace ParqueFarWest.Models
{
    [Table("Vehiculos")]
    public class Vehiculo
    {
        public int VehiculoId { get; set; }

        public int TipoDeVehiculoId { get; set; }

        public int MarcaId { get; set; }

        public string Modelo { get; set; }

        public string Patente { get; set; }

        public int Kilometraje { get; set; }
    }
}