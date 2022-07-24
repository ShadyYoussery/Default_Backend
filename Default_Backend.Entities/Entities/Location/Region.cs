using System;
using System.Collections.Generic;
using Default_Backend.Entities.Entities.Base;

namespace Default_Backend.Entities.Entities.Location
{
    public class Region : BaseEntity<Guid>
    {
        #region Property

        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public Guid CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<City> Cities { get; set; }

        #endregion Property
    }
}