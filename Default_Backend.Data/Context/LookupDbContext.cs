using Default_Backend.Entities.Entities.Lookup;
using Microsoft.EntityFrameworkCore;

namespace Default_Backend.Data.Context
{
    public partial class BackendCoreDbContext
    {
        #region Lookups
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Action> Actions { get; set; }
        #endregion

    }
}
