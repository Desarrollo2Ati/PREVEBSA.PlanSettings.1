using Microsoft.EntityFrameworkCore;
using PREVEBSAPlanSettingsClassLibrary.Interfaces;

namespace PREVEBSAPlanSettings.Data.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        private void DisableCascadingDelete(ModelBuilder modelBuilder)
        {
            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddTimestamps();
            return await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task<int> SaveWithMigrationChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is IEntityDelete && (x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted));

            foreach (var entity in entities)
            {
                DateTime DateNow = DateTime.Now;

                if (entity.State == EntityState.Added)
                {
                    ((IEntityDelete)entity.Entity).Created = DateNow;
                }

                ((IEntityDelete)entity.Entity).Updated = DateNow;

                if (entity.State == EntityState.Deleted)
                {
                    ((IEntityDelete)entity.Entity).Deleted = DateNow;
                    entity.State = EntityState.Modified;
                }
            }
        }
    }
}
