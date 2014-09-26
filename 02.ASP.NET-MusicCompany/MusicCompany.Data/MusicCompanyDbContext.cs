namespace MusicCompany.Data
{
    using System.Data.Entity;

    using MusicCompany.Models;
    using System.Data.Entity.Infrastructure;
    using MusicCompany.Data.Migrations;

    public class MusicCompanyDbContext : DbContext, IMusicCompanyDbContext
    {
        public MusicCompanyDbContext()
            : base("MusicCompanyConnection")
        { 
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicCompanyDbContext, Configuration>());
        }

        public IDbSet<Artist> Artists { get; set; }

        public IDbSet<Album> Albums { get; set; }

        public IDbSet<Song> Songs { get; set; }

        public void SaveChanges()
        {
            base.SaveChanges();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
