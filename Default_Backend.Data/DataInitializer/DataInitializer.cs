using System;
using System.Collections.Generic;
using System.Linq;
using Default_Backend.Common.Extensions;
using Default_Backend.Entities.Entities.Identity;
using Default_Backend.Entities.Entities.Lookup;
using Action = Default_Backend.Entities.Entities.Lookup.Action;
using Permission = Default_Backend.Entities.Entities.Identity.Permission;

namespace Default_Backend.Data.DataInitializer
{
    public class DataInitializer : IDataInitializer
    {
        #region Public Methods
        /// <summary>
        /// Seed Roles
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Role> SeedRoles()
        {
            var roleList = new List<Role>();
            roleList.AddRange(new[]
            {
                new Role
                {
                    Id = 1,
                    NameEn = "Admin",
                    NameAr = "مدير",
                    CreatedDate = new DateTime(2021, 1, 1),
                    ModifiedDate = new DateTime(2021, 1, 1)
                }

            });

            return roleList.ToArray();
        }
        /// <summary>
        /// Seed Users
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> SeedUsers()
        {
            var userList = new List<User>();
            userList.AddRange(new[]
            {
                new User
                {
                    Id =  Guid.Parse("abcc43c2-f7b8-4d70-8c1e-81bc61cb4518"),
                    NameEn = "Admin",
                    NameAr = "مدير",
                    Email = "Admin@admin.com",
                    Phone = "01016670280",
                    IsDeleted = false,
                    UserName = "admin",
                    Password = CryptoHasher.HashPassword("123456"),
                    RoleId = 1,
                    CreatedDate = new DateTime(2021, 1, 1),
                    ModifiedDate = new DateTime(2021, 1, 1)
                }

            });

            return userList.ToArray();
        }

        /// <summary>
        /// Seed Permissions
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Permission> SeedPermissions()
        {
            var permissionList = new List<Permission>();
            permissionList.AddRange(new[]
            {
                new Permission
                {
                    Id = 1,
                    NameEn = "Add",
                    NameAr = "اضافة",
                    Code = "Add",
                    CreatedDate = new DateTime(2021, 1, 1),
                    ModifiedDate = new DateTime(2021, 1, 1)
                },
                new Permission
                {
                    Id = 2,
                    NameEn = "Edit",
                    NameAr = "تعديل",
                    Code = "Edit",
                    CreatedDate = new DateTime(2021, 1, 1),
                    ModifiedDate = new DateTime(2021, 1, 1)
                },
                new Permission
                {
                    Id = 3,
                    NameEn = "View",
                    NameAr = "عرض",
                    Code = "View",
                    CreatedDate = new DateTime(2021, 1, 1),
                    ModifiedDate = new DateTime(2021, 1, 1)
                },
                new Permission
                {
                    Id = 4,
                    NameEn = "Delete",
                    NameAr = "حذف",
                    Code = "Delete",
                    CreatedDate = new DateTime(2021, 1, 1),
                    ModifiedDate = new DateTime(2021, 1, 1)
                }

            });

            return permissionList.ToArray();
        }
        /// <summary>
        /// Seed Actions
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Action> SeedActions()
        {
            var enums = Enum.GetValues(typeof(Entities.Enum.ActionEnum));
            return (from object enumItem in enums
                select new Action
                {
                    Id = (int)(Entities.Enum.ActionEnum)enumItem,
                    NameEn = ((Entities.Enum.ActionEnum)enumItem).GetName().NameEn,
                    NameAr = ((Entities.Enum.ActionEnum)enumItem).GetName().NameAr,
                    Code = ((Entities.Enum.ActionEnum)enumItem).GetName().Code,
                    CreatedDate = new DateTime(2021, 1, 1),
                    ModifiedDate = new DateTime(2021, 1, 1)

                }).ToList();
        }
        /// <summary>
        /// Seed Statuses
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Status> SeedStatuses()
        {
            var enums = Enum.GetValues(typeof(Entities.Enum.StatusEnum));
            return (from object enumItem in enums
                select new Status
                {
                    Id = (int)(Entities.Enum.StatusEnum)enumItem,
                    NameEn = ((Entities.Enum.StatusEnum)enumItem).GetName().NameEn,
                    NameAr = ((Entities.Enum.StatusEnum)enumItem).GetName().NameAr,
                    Code = ((Entities.Enum.StatusEnum)enumItem).GetName().Code,
                    CreatedDate = new DateTime(2021, 1, 1),
                    ModifiedDate = new DateTime(2021, 1, 1)

                }).ToList();
        }

        #endregion

    }
}