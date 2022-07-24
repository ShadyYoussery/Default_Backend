using System;
using System.Collections.Generic;
using Default_Backend.Entities.Entities.Base;

namespace Default_Backend.Entities.Entities.Location
{
    public class City : BaseEntity<Guid>
    {
        #region Property

        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public Guid RegionId { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<District> Districts { get; set; }

        #endregion Property
    }
}