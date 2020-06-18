using clase8mvc.Entities;
using Microsoft.EntityFrameworkCore;

namespace clase8mvc.DTO
{
    public class MySqlContext : DbContext
    {
        public DbSet<PeliculaEntity> peliculaEntities { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;port=3306;database=codigocode;user=root;password=");
        }



    }
}