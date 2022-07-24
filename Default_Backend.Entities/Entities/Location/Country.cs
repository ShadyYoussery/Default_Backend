using System;
using System.Collections.Generic;
using Default_Backend.Entities.Entities.Base;

namespace Default_Backend.Entities.Entities.Location
{
    public class Country : BaseEntity<Guid>
    {
        #region Property

        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public virtual ICollection<Region> Regions { get; set; }

        #endregion Property
    }
}