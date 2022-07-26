﻿using Default_Backend.Entities.Entities.Identity;
using Microsoft.EntityFrameworkCore;

namespace Default_Backend.Data.Context
{
    public partial class BackendCoreDbContext
    {
        #region Identity Entities
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        #endregion

    }
}
