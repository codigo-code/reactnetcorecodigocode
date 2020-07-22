

using backend.modelo;
using Microsoft.EntityFrameworkCore;

namespace backend.DB
{

    public class MySQLContext : DbContext
    {

        public DbSet<Usuario> usuarioDB { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=codigocode;user=root;password=");
        }


    }
}