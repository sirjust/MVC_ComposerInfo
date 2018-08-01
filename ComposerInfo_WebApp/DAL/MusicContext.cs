using ComposerInfo_WebApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ComposerInfo_WebApp.DAL
{
    public class MusicContext : DbContext
    {

        public MusicContext() : base("MusicContext")
        {
        }

        public DbSet<Composer> Composers { get; set; }
        public DbSet<Opera> Operas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}