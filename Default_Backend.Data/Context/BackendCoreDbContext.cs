using Default_Backend.Common.Services;
using Default_Backend.Data.Configuration;
using Default_Backend.Data.DataInitializer;
using Default_Backend.Entities.Entities.Business;
using Default_Backend.Entities.Entities.Common;
using Default_Backend.Entities.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Action = Default_Backend.Entities.Entities.Lookup.Action;
using Status = Default_Backend.Entities.Entities.Lookup.Status;

namespace Default_Backend.Data.Context
{
    public partial  class BackendCoreDbContext : DbContext
    {
        private readonly IDataInitializer _dataInitializer;
        private readonly IClaimService _claimService;
        public BackendCoreDbContext(DbContextOptions<BackendCoreDbContext> options, IDataInitializer dataInitializer, IClaimService claimService) : base(options)
        {
            _dataInitializer = dataInitializer;
            _claimService = claimService;
        }

        #region Business
        public virtual DbSet<Attachment> Attachments { get; set; }
        #endregion

        #region Common Entities

        public virtual DbSet<File> Files { get; set; }

        #endregion

        #region Overriden Methods
        /// <summary>
        /// On Model Creating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Configuration

            modelBuilder.ApplyConfiguration(new PermissionConfig());

            #endregion

            #region Seed

            modelBuilder.Entity<Role>().HasData(_dataInitializer.SeedRoles());
            modelBuilder.Entity<User>().HasData(_dataInitializer.SeedUsers());
            modelBuilder.Entity<Permission>().HasData(_dataInitializer.SeedPermissions());
            modelBuilder.Entity<Status>().HasData(_dataInitializer.SeedStatuses());
            modelBuilder.Entity<Action>().HasData(_dataInitializer.SeedActions());
            #endregion
            base.OnModelCreating(modelBuilder);
        }
        

        #endregion

        #region Private Methods
        #endregion

    }
}
