using System.Collections.Generic;
using Default_Backend.Entities.Entities.Identity;
using Default_Backend.Entities.Entities.Lookup;

namespace Default_Backend.Data.DataInitializer
{
    public interface IDataInitializer
    {
        IEnumerable<Role> SeedRoles();
        IEnumerable<User> SeedUsers();
        IEnumerable<Permission> SeedPermissions();
        IEnumerable<Action> SeedActions();
        IEnumerable<Status> SeedStatuses();
    }
}