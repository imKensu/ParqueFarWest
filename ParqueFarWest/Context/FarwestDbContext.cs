using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ParqueFarWest.Models;

namespace ParqueFarWest.Context
{
    public class FarwestDbContext:DbContext
    {
        public FarwestDbContext():base("MiConexion")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<FarwestDbContext>(null);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Provincia> Provincias { get; set; }

        public DbSet<Vehiculo> Vehiculos { get; set; }

        public DbSet<EstacionDeServicio> EstacionDeServicios { get; set; }

        public DbSet<MarcaDeCombustibleYLubricante> MarcaDeCombustibleYLubricantes { get; set; }

        public DbSet<CombustibleYLubricante> CombustibleYLubricantes { get; set; }
    }
}