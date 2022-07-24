using System.Collections.Generic;
using System.Collections.ObjectModel;
using Default_Backend.Entities.Entities.Base;

namespace Default_Backend.Entities.Entities.Identity
{
    public class Role : BaseEntity<long>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public virtual  ICollection<User> Users{ get; set; } = new Collection<User>();
    }
}
